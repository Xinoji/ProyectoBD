using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoBD.Modelos;

namespace ProyectoBD.Modelos
{
    public partial class FormRePreventivo : Form
    {
        private int max_semana;
        public int semana_registrada { get; set; }
        public FormRePreventivo(int max_semana,int x,int y,Color b,Color f,Color bb,Color bf)
        {

            InitializeComponent();
            
            this.max_semana = max_semana;

            BackColor = b;
            label1.BackColor = b;
            label1.ForeColor = f;

            b_cancel.BackColor = bb;
            b_cancel.ForeColor = bf;

            b_reagendar.BackColor = bb;
            b_reagendar.ForeColor = bf;

            lector_semana.BackColor = ControlPaint.Light(b,0.4f);
            lector_semana.ForeColor = f;


            Left = x - (Width/2);
            Top = y - (Height/2);

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
