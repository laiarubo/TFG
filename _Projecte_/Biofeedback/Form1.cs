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

namespace Biofeedback
{
    public partial class Form1 : Form
    {
        // ======= VARIABLES GLOBALS =======

        // Per a la connexió PC - Arduino
        bool CONNECTAT = false;
        string[] PORTS;
        SerialPort PORT;

        // Per al quadern de bitàcola
        public StreamReader STR;
        public StreamWriter STW;
        public string TEXT_REBRE;
        public string TEXT_ENVIAR;

        // Reproducció del vídeo/àudio (vista terapeuta)
        bool ESTIMUL_DISPONIBLE = false;
        int COMPTADOR_VIDEO = 0;
        bool ATURA_PRIMER = true;

        // Reproducció del vídeo/àudio (vista pacient)
        private Form2 FRM2;
        bool PRIMER_COP = true;
        bool REPRODUINTSE = false;

        // =================================

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
            if (!CONNECTAT)
            {
                connectarArduino();
            }

            backgroundWorker1.WorkerSupportsCancellation = true; 
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToShortDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }
      
        private void timer1_Tick(object sender, EventArgs e) // Perquè s'actualitzin els segons de l'hora
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void connectarArduino()
        {
            CONNECTAT = true;
            string portSeleccionat = comboBox1.GetItemText(comboBox1.SelectedItem);

            // public SerialPort (string portName, int baudRate, System.IO.Ports.Parity parity);
            PORT = new SerialPort(portSeleccionat, 9600, Parity.None, 8, StopBits.One);

            PORT.Open(); // S'activa el port COM
            PORT.Write("#INICI\n");
        }

        private void NotesTerapeuta_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CONNECTAT)
            {
                if (checkBox1.Checked)
                {
                    PORT.Write("#LED_ON\n");
                }
                else
                {
                    PORT.Write("#LED_OFF\n");
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CONNECTAT)
            {

                QuadernBitacoles_richTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    QuadernBitacoles_richTextBox.AppendText(DateTime.Now.ToLongTimeString() + "    " + TEXT_ENVIAR + Environment.NewLine);
                    PintarNotesDeBlau();
                }));
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
            int matchCount = 0;
            foreach (Match match in matches)
            {
                // Posar tota la línia del terapeuta de color blau
                QuadernBitacoles_richTextBox.Select(match.Index, match.Length);
                QuadernBitacoles_richTextBox.SelectionColor = Color.Blue;

                // Posar "Nota:" en negreta
                Match match2 = Regex.Match(match.Value, "Nota:");
                QuadernBitacoles_richTextBox.Select(match.Index + match2.Index, match2.Length); // Línia + columna per trobar la nota de cada línia
                QuadernBitacoles_richTextBox.SelectionFont = new Font(QuadernBitacoles_richTextBox.Font, FontStyle.Bold);
            }
        }
        private void BotoEnvia_Click(object sender, EventArgs e)
        {

            if (CONNECTAT)
            {
                if (NotesTerapeuta.Text != "")
                {
                    TEXT_ENVIAR = "Nota: " + NotesTerapeuta.Text;
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
                    PRIMER_COP = false;
                    WindowsMediaPlayer1.URL = rutaFitxer.Text;
                    WindowsMediaPlayer1.Ctlcontrols.play();
                    botoPlayVideo.Text = "| |";
                    TEXT_ENVIAR = "S'inicia l'estímul"; // VALORAR SI VAL LA PENA UTILITZAR TEXT_REBRE
                    backgroundWorker1.RunWorkerAsync();
                    FRM2.PlayPrimerCop();
                }
                // Pausar
                else if (REPRODUINTSE)
                {
                    WindowsMediaPlayer1.Ctlcontrols.pause();
                    botoPlayVideo.Text = "▶";
                    TEXT_ENVIAR = "Es pausa l'estímul"; // VALORAR SI VAL LA PENA UTILITZAR TEXT_REBRE
                    backgroundWorker1.RunWorkerAsync();
                    FRM2.Pause();
                }
                // Reprendre
                else
                {
                    WindowsMediaPlayer1.Ctlcontrols.play();
                    botoPlayVideo.Text = "| |";
                    TEXT_ENVIAR = "Es reprèn l'estímul"; // VALORAR SI VAL LA PENA UTILITZAR TEXT_REBRE
                    backgroundWorker1.RunWorkerAsync();
                    FRM2.Play();
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
                    TEXT_ENVIAR = "S'atura l'estímul"; // VALORAR SI VAL LA PENA UTILITZAR TEXT_REBRE
                    backgroundWorker1.RunWorkerAsync();
                    FRM2.Stop();
                }
            }
            else
            {
                MessageBox.Show("Si us plau, seleccioni un estímul.");
            }
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
    }
}
