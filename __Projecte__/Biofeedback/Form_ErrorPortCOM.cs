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
    public partial class Form_ErrorPortCOM : Form
    {
        public Form_ErrorPortCOM()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MissatgeError_Click(object sender, EventArgs e)
        {

        }
    }
}
