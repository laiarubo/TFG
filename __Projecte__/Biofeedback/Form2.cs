using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biofeedback
{
    public partial class Form2 : Form
    {
        string RUTA;
        public Form2(string rutaForm1)
        {
            InitializeComponent();
            RUTA = rutaForm1;
            WindowsMediaPlayer2.uiMode = "none"; // Amaga els controls del WindowsMediaPlayer

            Connexio_Singleton.getInstance().nouEventCardiograma += MostraValorsArduino_Cardio;
            Connexio_Singleton.getInstance().nouEventMiograma += MostraValorsArduino_Mio;
            Connexio_Singleton.getInstance().nouEventRespostaGalvanica += MostraValorsArduino_RG;
        }

        public void PlayPrimerCop()
        {
            WindowsMediaPlayer2.URL = RUTA;
            WindowsMediaPlayer2.Ctlcontrols.play();
        }

        public void PlayVideo()
        {
            WindowsMediaPlayer2.Ctlcontrols.play();
        }

        public void PauseVideo()
        {
            WindowsMediaPlayer2.Ctlcontrols.pause();
        }

        public void StopVideo()
        {
            WindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void WindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }

        private void MostraValorsArduino_Cardio(string s)
        {
            lecturaCardio.Invoke((MethodInvoker)(() => lecturaCardio.Text = s));
        }

        private void MostraValorsArduino_Mio(string s)
        {
            lecturaMio.Invoke((MethodInvoker)(() => lecturaMio.Text = s));
        }

        private void MostraValorsArduino_RG(string s)
        {
            lecturaRG.Invoke((MethodInvoker)(() => lecturaRG.Text = s));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
