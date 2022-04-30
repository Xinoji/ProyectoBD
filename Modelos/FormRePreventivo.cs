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
    public partial class FormRePreventivo : Form
    {
        private int max_semana;
        public int semana_registrada { get; set; }
        public FormRePreventivo(int max_semana)
        {
            InitializeComponent();
            this.max_semana = max_semana;
            
            this.Location = new Point(MousePosition.X - 50, MousePosition.Y - 50);

            b_cancel.Click += new EventHandler(cancelar);
            b_reagendar.Click += new EventHandler(reagendar);
        }
        public void reagendar(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(lector_semana.Text)) {
                MessageBox.Show("Ingrese una semana");
                return;
            }

            try
            {
                this.semana_registrada = Int32.Parse(lector_semana.Text);

                if (this.semana_registrada > 0 && semana_registrada <= max_semana)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else {
                    MessageBox.Show("Semana fuera de rango");
                }
            }
            catch (FormatException) {
                MessageBox.Show("Ingrese un valor valido");
            }
        }   
        public void cancelar(object sender, EventArgs e) {
            this.semana_registrada = -1;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
