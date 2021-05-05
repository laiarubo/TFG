using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using ContingutBD;

namespace Biofeedback
{
    public partial class Form1 : Form
    {
        // ======= VARIABLES GLOBALS =======

        // Per a la comunicació amb la BD
        List<QuadernModel> QUADERN_BD = new List<QuadernModel>();

        // Per a la connexió PC - Arduino
        string[] PORTS;

        // Per al quadern de bitàcola
        public StreamReader STR;
        public StreamWriter STW;
        public string TEXT_ENVIAR;

        // Reproducció del vídeo/àudio (vista terapeuta)
        bool ESTIMUL_DISPONIBLE = false;
        bool ATURA_PRIMER = true;

        // Reproducció del vídeo/àudio (vista pacient)
        private Form2 FRM2;
        private Form_ErrorPortCOM FRM_e;
        bool PRIMER_COP = true;
        bool REPRODUINTSE = false;

        // =================================

        private short _minutsSessio, _segonsSessio;
        private short _minutsEstimul, _segonsEstimul;

        public Form1()
        {
            InitializeComponent();
           
            PORTS = SerialPort.GetPortNames();
            
            foreach (string PORT in PORTS)
            {
                comboBox1.Items.Add(PORT); // Es llisten els ports COM disponibles
                Console.WriteLine(PORT);
                if (PORTS[0] != null)
                {
                    comboBox1.SelectedItem = PORTS[0];
                }
            }

            // Connexió PC - Arduino automàtica
            if (comboBox1.Items.Count > 0) // Si hi ha algun port disponible, que agafi el primer
                comboBox1.SelectedIndex = 0;

            if (!Connexio_Singleton.getInstance().portObert())
            {
                FRM_e = new Form_ErrorPortCOM();
                FRM_e.Show();
                WindowState = FormWindowState.Minimized; // Perquè només es vegi el missatge d'error
            }
            //MessageBox.Show("No s'ha pogut establir la connexió amb l'Arduino.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            backgroundWorker1.WorkerSupportsCancellation = true;

            // Durada de la sessió i minut estímul:

            _minutsSessio = 0;
            _segonsSessio = 0;
            _minutsEstimul = 0;
            _segonsEstimul = 0;
            mostraDuradaSessio();
            timer_sessio.Interval = 1000; // 1 tick cada segon
            timer_estimul.Interval = 1000;
            timer_sessio.Enabled = true;
        }

        private void mostraDuradaSessio()
        {
            minutsSessio.Text = _minutsSessio.ToString("00");
            segonsSessio.Text = _segonsSessio.ToString("00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

            WindowsMediaPlayer1.uiMode = "none"; // Amaga els controls del WindowsMediaPlayer

            // Carregar les dades a la BD
       //     QUADERN_BD = SqliteDataAccess.LoadQuadern();
        }
      
        private void timer1_Tick(object sender, EventArgs e) // Perquè s'actualitzin els segons de l'hora
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connexio_Singleton.getInstance().ConnectarArduino(comboBox1.Items[comboBox1.SelectedIndex].ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Connexio_Singleton.getInstance().portObert())
            {
                if (checkBox1.Checked)
                   Connexio_Singleton.getInstance().writeCommand("#LED_ON\n");
                else
                    Connexio_Singleton.getInstance().writeCommand("#LED_OFF\n");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Connexio_Singleton.getInstance().portObert())
            {

                QuadernBitacoles_richTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    QuadernBitacoles_richTextBox.AppendText(DateTime.Now.ToLongTimeString() + "    " + TEXT_ENVIAR + Environment.NewLine);
                    PintarNotesDeBlau();
                }));

                //QuadernModel q = new QuadernModel();
                //q.Missatge = DateTime.Now.ToLongTimeString() + "    " + TEXT_ENVIAR;
                //SqliteDataAccess.DesaQuadern(q);
            }
            else
            {
                MessageBox.Show("Error: Arduino no connectat.");
            }
            backgroundWorker1.CancelAsync();
        }
        public void PintarNotesDeBlau()
        {
            MatchCollection matches = Regex.Matches(QuadernBitacoles_richTextBox.Text, ".*Nota:.*\n");

            //Apply color to all matching text
            foreach (Match match in matches)
            {
                // Posar tota la línia del terapeuta de color blau
                QuadernBitacoles_richTextBox.Select(match.Index, match.Length);
                QuadernBitacoles_richTextBox.SelectionColor = Color.HotPink;

                // Posar "Nota:" en negreta
                Match match2 = Regex.Match(match.Value, "Nota:");
                QuadernBitacoles_richTextBox.Select(match.Index + match2.Index, match2.Length); // Línia + columna per trobar la nota de cada línia
                QuadernBitacoles_richTextBox.SelectionFont = new Font(QuadernBitacoles_richTextBox.Font, FontStyle.Bold);
            }
        }
        private void BotoEnvia_Click(object sender, EventArgs e)
        {

            if (Connexio_Singleton.getInstance().portObert())
            {
                if (NotesTerapeuta.Text != "")
                {
                    TEXT_ENVIAR = "(" + _minutsEstimul + ":" + _segonsEstimul + ")   " + "Nota: " + NotesTerapeuta.Text;
                    backgroundWorker1.RunWorkerAsync();
                }
                NotesTerapeuta.Text = "";
            }
            else
            {
                MessageBox.Show("Error: Arduino no connectat.");
            }
        }

        private void NotesTerapeuta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //BotoEnvia_Click(this, new EventArgs()); // Fa el mateix que la línia següent:
                BotoEnvia.PerformClick();
            }
        }

        private void botoCercaVideo_Click(object sender, EventArgs e) // Per obrir el fitxer vídeo/àudio i que es mostri la seva ruta a la textBox 
        {
            OpenFileDialog objFitxerObrir = new OpenFileDialog();

            if (objFitxerObrir.ShowDialog() == /*System.Windows.Forms.*/DialogResult.OK) // Si troba el fitxer...
            {
                /*this.*/rutaFitxer.Text = objFitxerObrir.FileName;
                ESTIMUL_DISPONIBLE = true;

                TEXT_ENVIAR = "S'ha seleccionat l'estímul " + rutaFitxer.Text;
                backgroundWorker1.RunWorkerAsync();
             
                
                
                //WindowsMediaPlayer1.URL = rutaFitxer.Text;
                //WindowsMediaPlayer1.Ctlcontrols.play();
                FRM2 = new Form2(rutaFitxer.Text);  // Només es pot fer PLAY. No es pot fer pausa ni res perquè no deixa prémer els botons del form1
                //f.ShowDialog(); // No utilitzo aquest perquè sinó no deixa utilitzar el form1
                FRM2.Show();
            }
        }

        private void botoPlayVideo_Click(object sender, EventArgs e)
        {
            if (ESTIMUL_DISPONIBLE)
            {           
                ATURA_PRIMER = false;

                // Play (1r cop)
                if (PRIMER_COP)
                {
                    timer_estimul.Enabled = true;

                    PRIMER_COP = false;
                    WindowsMediaPlayer1.URL = rutaFitxer.Text;
                    WindowsMediaPlayer1.Ctlcontrols.play();
                    WindowsMediaPlayer1.settings.volume = 0;
                    botoPlayVideo.Text = "| |";
                    TEXT_ENVIAR = "(" + _minutsEstimul + ":" + _segonsEstimul + ")   " + "S'inicia l'estímul"; // VALORAR SI VAL LA PENA UTILITZAR TEXT_REBRE
                    backgroundWorker1.RunWorkerAsync();
                    FRM2.PlayPrimerCop();
                }
                // Pausar
                else if (REPRODUINTSE)
                {
                    timer_estimul.Enabled = false;

                    WindowsMediaPlayer1.Ctlcontrols.pause();
                    botoPlayVideo.Text = "▶";
                    TEXT_ENVIAR = "(" + _minutsEstimul + ":" + _segonsEstimul + ")   " + "Es pausa l'estímul"; // VALORAR SI VAL LA PENA UTILITZAR TEXT_REBRE
                    backgroundWorker1.RunWorkerAsync();
                    FRM2.PauseVideo();
                }
                // Reprendre
                else
                {
                    timer_estimul.Enabled = true;

                    WindowsMediaPlayer1.Ctlcontrols.play();
                    botoPlayVideo.Text = "| |";
                    TEXT_ENVIAR = "(" + _minutsEstimul + ":" + _segonsEstimul + ")   " + "Es reprèn l'estímul"; // VALORAR SI VAL LA PENA UTILITZAR TEXT_REBRE
                    backgroundWorker1.RunWorkerAsync();
                    FRM2.PlayVideo();
                }

                REPRODUINTSE = !REPRODUINTSE;                
            }    
            else
            {
                MessageBox.Show("Si us plau, seleccioni un estímul.");
            }
        }

        // Atura
        private void botoAturaVideo_Click(object sender, EventArgs e)
        {
            if (ESTIMUL_DISPONIBLE)
            {
                if (ATURA_PRIMER == false)
                {
                    //COMPTADOR_VIDEO = 0;
                    REPRODUINTSE = false;
                    WindowsMediaPlayer1.Ctlcontrols.stop();
                    botoPlayVideo.Text = "▶";
                    TEXT_ENVIAR = "(" + _minutsEstimul + ":" + _segonsEstimul + ")   " + "S'atura l'estímul"; // VALORAR SI VAL LA PENA UTILITZAR TEXT_REBRE
                    backgroundWorker1.RunWorkerAsync();
                    FRM2.StopVideo();

                    ReiniciaTimerEstimul();
                }
            }
            else
            {
                MessageBox.Show("Si us plau, seleccioni un estímul.");
            }
        }

        private void timer_sessio_Tick(object sender, EventArgs e)
        {
            IncrementaSegonsSessio();
            mostraDuradaSessio();
        }

        private void timer_estimul_Tick(object sender, EventArgs e)
        {
            IncrementaSegonsEstimul();
        }

        private void IncrementaSegonsSessio()
        {
            if (_segonsSessio == 59)
            {
                _segonsSessio = 0;
                IncrementaMinutsSessio();
            }
            else
                _segonsSessio++;
        }

        private void IncrementaSegonsEstimul()
        {
            if (_segonsEstimul == 59)
            {
                _segonsEstimul = 0;
                IncrementaMinutsEstimul();
            }
            else
                _segonsEstimul++;
        }

        private void IncrementaMinutsSessio()
        {
            _minutsSessio++;
        }

        private void IncrementaMinutsEstimul()
        {
            _minutsEstimul++;
        }

        private void ReiniciaTimerEstimul()
        {
            _minutsEstimul = 0;
            _segonsEstimul = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void duradaSessioTitol_Click(object sender, EventArgs e)
        {

        }

        private void liveCharts_UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rutaFitxer_TextChanged(object sender, EventArgs e)
        {

        }

        private void WindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void QuadernBitacoles_richTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void NotesTerapeuta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
