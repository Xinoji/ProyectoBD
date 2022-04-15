using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e){
            panelNavegacion.ForeColor = Color.White;
            panelNavegacion.BackColor = WinTheme.GetAccentColor();
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
