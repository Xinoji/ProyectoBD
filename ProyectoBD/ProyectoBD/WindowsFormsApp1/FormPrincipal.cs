using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackColor = WinTheme.GetAccentColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           FormDashboard f = new FormDashboard();
            f.Show();
        }
    }
}
