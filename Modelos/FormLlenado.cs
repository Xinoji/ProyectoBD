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
    public partial class FormLlenado : Form
    {
        private int folio;
        public FormLlenado()
        {
            InitializeComponent();
            btnSubir.Click += new System.EventHandler(insert);
        }
        public FormLlenado(int Folio)
        {
            folio = Folio;
            InitializeComponent();
            btnSubir.Click +=  new System.EventHandler(update);
        }
        private void insert(object sender, EventArgs e)
        {
            MessageBox.Show("Subir Nuevo Registro");
        }
        private void update(object sender, EventArgs e)
        {
            MessageBox.Show("Subir Actualizar Registro");
        }

    }
}
