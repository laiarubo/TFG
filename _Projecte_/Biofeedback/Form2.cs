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
    }
}
