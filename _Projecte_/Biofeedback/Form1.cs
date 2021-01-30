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

            // Quadern de bitàcola
       //     backgroundWorker1.RunWorkerAsync(); // L'aplicació llista els events
            backgroundWorker1.WorkerSupportsCancellation = true; // El terapeuta publica notes
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

        private void reiniciarQC()
        {
            checkBox1.Checked = false;
        }

        private void c_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (CONNECTAT)
            {
                this.QuadernDeBitacola.Invoke(new MethodInvoker(delegate ()
                {
                    QuadernDeBitacola.AppendText(DateTime.Now.ToShortTimeString() + "    Nota: " + TEXT_ENVIAR + System.Environment.NewLine);
                }));
            }
            else
            {
                MessageBox.Show("Hi ha algun error. No es pot enviar la nota.");
            }
            backgroundWorker1.CancelAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NotesTerapeuta.Text != "")
            {
                TEXT_ENVIAR = NotesTerapeuta.Text;
                backgroundWorker1.RunWorkerAsync();
            }
            NotesTerapeuta.Text = "";
        }

        private void NotesTerapeuta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //button1_Click(this, new EventArgs()); // Fa el mateix que la línia següent:
                button1.PerformClick();
            }
        }

        private void QuadernDeBitacola_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
