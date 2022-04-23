using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD.Modelos
{
    public partial class ControlDatosCorrectivo : UserControl
    {
        public ControlDatosCorrectivo()
        {
            InitializeComponent();
            Height = 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Height += 30;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Height += 30;
            }
            else
            {
                Height -= 30;
            }
        }

     
    }
}
