using System;
using System.IO.Ports;
using System.Windows.Forms;

/* ===========================================================
 *                   COMANDES PER A L'ARDUINO
 * ===========================================================
 * 
 * #INICI\n    -->    Inicialitza la comunicació amb l'Arduino
 * #FINAL\n    -->    Finalitza la comunicació amb l'Arduino
 * #LED_ON\n   -->    Encén el LED
 * #LED_OFF\n  -->    Apaga el LED
*/

namespace ProvaComunicacioArduinoPC
{    public partial class Form1 : Form
    {
        // VARIABLES GLOBALS
        bool CONNECTAT = false;
        string[] PORTS;
        SerialPort PORT;

        public Form1()
        {
            InitializeComponent(); // Aquesta funció ve per defecte
            //deshabilitaControlsQC();
            PORTS = SerialPort.GetPortNames();

            foreach (string PORT in PORTS)
            {
                comboBox1.Items.Add(PORT); // Es llisten els ports COM disponibles
                Console.WriteLine(PORT); 
                if (PORTS[0] != null) {
                    comboBox1.SelectedItem = PORTS[0];
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // Si elimino això, peta el design (però no sé què és)
        {
            if (!CONNECTAT)
            {
                connectarArduino();
            }
            else
            {
                desconnectarArduino();
            }
        }

       /* private void LEDCheckboxClicked(object sender, EventArgs e)

        {
            if (CONNECTAT)
            {
                if (checkBox1.Checked) {
                    PORT.Write("#LED_ON\n");
                }
                else {
                    PORT.Write("#LED_OFF\n");
                }
            }
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deshabilitaControlsQC() // Els controls del quadre de comandament (QC) surten de color gris
        {
            checkBox1.Enabled = false;
            button1.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void habilitaControlsQC() // Els controls del QC es poden utilitzar (deixen de ser grisos)
        {
            checkBox1.Enabled = true;
            button1.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void reiniciarQC() {
            checkBox1.Checked = false;
        }

        private void connectarArduino()
        {
            CONNECTAT = true;
            string portSeleccionat = comboBox1.GetItemText(comboBox1.SelectedItem);

            // public SerialPort (string portName, int baudRate, System.IO.Ports.Parity parity);
            PORT = new SerialPort(portSeleccionat, 9600, Parity.None, 8, StopBits.One);

            PORT.Open(); // S'activa el port COM
            PORT.Write("#INICI\n"); 

            button1.Text = "Desconnecta";

            habilitaControlsQC();
        }

        private void desconnectarArduino()
        {
            CONNECTAT = false;
            PORT.Write("#FINAL\n");
            PORT.Close();
            button1.Text = "Connecta";
            //deshabilitaControlsQC();
            reiniciarQC();
        }

    }
}
