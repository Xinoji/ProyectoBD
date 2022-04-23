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
    public struct preventivo 
    {
        public string maquina;
        List<KeyValuePair<int,string>> planes;
    }
    public partial class FormPreventivo : Form
    {
        
        private List<string> maquinas;
        
        public FormPreventivo()
        {
            InitializeComponent();
        }


        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = new ControlPlan();
            a.Dock = DockStyle.Top;
            panel1.Controls.Add(a);
            a.BringToFront();
        }
    }
}
