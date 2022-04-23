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
    public partial class ControlPlan : UserControl
    {
        private RadioButton active;
        public string plan;
        public ControlPlan()
        {
            InitializeComponent();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
          
            if (((RadioButton)sender).Checked)
            {
                

                active = (RadioButton)sender;
                plan = active.Text;
                
                MessageBox.Show(plan);
            }
           
        }
    }
}
