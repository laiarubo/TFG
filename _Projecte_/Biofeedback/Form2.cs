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
        }

        public void PlayPrimerCop()
        {
            WindowsMediaPlayer2.URL = RUTA;
            WindowsMediaPlayer2.Ctlcontrols.play();
        }

        public void Play()
        {
            WindowsMediaPlayer2.Ctlcontrols.play();
        }

        public void Pause()
        {
            WindowsMediaPlayer2.Ctlcontrols.pause();
        }

        public void Stop()
        {
            WindowsMediaPlayer2.Ctlcontrols.stop();
        }
    }
}
