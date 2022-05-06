using ProyectoBD.Logica;
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
    public partial class FormIngresa : Form
    {
        //campos y propiedades
        private Button Activo;
        private bool cambiando;
        private Altas datos;
        private string key;

        public FormIngresa()
        {
            InitializeComponent();
            btnMecanico.Enabled = false;
            Activo = btnMecanico;

            btnAgregar.Click += new System.EventHandler(this.btnAgregar_Mecanico);
            btnActualizar.Click += new System.EventHandler(this.btnActualizar_Mecanico);
            dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mecanico_CellDoubleClick);
            cambiando = false;
            datos = new Altas();
            getMecanicos();
            ocultar();
            ResetMecanico();
            
        }

        private async void btnControl_Click(object sender, EventArgs e)
        {
            if (cambiando)
            {
                MessageBox.Show("Aun no termina de actualizar la tabla espere...");
            }
            else
            {
                key = "";

                btnAgregar.Visible = true;
                btnActualizar.Visible = false;
                btnRegresar.Visible = false;

                cambiando = true;
                Activo.Enabled = !Activo.Enabled;


                btnAgregar.Click -= new System.EventHandler(this.btnAgregar_Mecanico);
                btnActualizar.Click -= new System.EventHandler(this.btnActualizar_Mecanico);
                dataGridView1.CellDoubleClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.Mecanico_CellDoubleClick);


                btnAgregar.Click -= new System.EventHandler(this.btnAgregar_Operador);
                btnActualizar.Click -= new System.EventHandler(this.btnActualizar_Operador);
                dataGridView1.CellDoubleClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.Operador_CellDoubleClick);
                

                btnAgregar.Click -= new System.EventHandler(this.btnAgregar_Maquina);
                btnActualizar.Click -= new System.EventHandler(this.btnActualizar_Maquina);
                dataGridView1.CellDoubleClick -= new System.Windows.Forms.DataGridViewCellEventHandler(this.Maquina_CellDoubleClick);


                Activo = (Button)sender;
                ocultar();
                if (Activo == btnMecanico)
                {
                    getMecanicos();
                    ResetMecanico();
                    btnAgregar.Click += new System.EventHandler(this.btnAgregar_Mecanico);
                    btnActualizar.Click += new System.EventHandler(this.btnActualizar_Mecanico);
                    dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mecanico_CellDoubleClick);
                }
                if (Activo == btnOperador)
                {
                    getOperadores();
                    ResetOperador();
                    btnAgregar.Click += new System.EventHandler(this.btnAgregar_Operador);
                    btnActualizar.Click += new System.EventHandler(this.btnActualizar_Operador);
                    dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Operador_CellDoubleClick);
                }
                if (Activo == btnMaquina)
                {
                    getMaquinas();
                    ResetMaquina();
                    btnAgregar.Click += new System.EventHandler(this.btnAgregar_Maquina);
                    btnActualizar.Click += new System.EventHandler(this.btnActualizar_Maquina);
                    dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Maquina_CellDoubleClick);
                }
                Activo.Enabled = !Activo.Enabled;
            }

            
            
        }

        private void btnAgregar_Maquina(object sender, EventArgs e)
        {
            datos.insertMaquina(tbNombre.Text, numProduccion.Value, tbTipoEstudio.Text, tbSerie.Text, (int)numAncho.Value, (int)numAlto.Value);
            getMaquinas();
        }

        private void btnAgregar_Operador(object sender, EventArgs e)
        {
            datos.insertOperador(tbNombre.Text,tbTipoEstudio.Text);
            getOperadores();
        }

        private void btnAgregar_Mecanico(object sender, EventArgs e)
        {
            datos.insertMecanico(tbNombre.Text,tbTipoEstudio.Text,dtpEdad.Value);
            getMecanicos();
        }

        private void btnActualizar_Maquina(object sender, EventArgs e)
        {
            datos.updateMaquina(tbNombre.Text, numProduccion.Value, tbTipoEstudio.Text, tbSerie.Text, (int)numAncho.Value, (int)numAlto.Value, key);
            getMaquinas();
        }

        private void btnActualizar_Operador(object sender, EventArgs e)
        {
            datos.updateOperador(tbNombre.Text, tbTipoEstudio.Text, key);
            getOperadores();
        }

        private void btnActualizar_Mecanico(object sender, EventArgs e)
        {
            datos.updateMecanico(tbNombre.Text, tbTipoEstudio.Text, dtpEdad.Value, key);
            getMecanicos();
        }

        private async Task getMecanicos()
        {
            await Task.Run(() => datos.getTable("Mecanico"));
            dataGridView1.DataSource = datos.tabla;
            cambiando = false;
            
        }

        private async Task getOperadores()
        {
            await Task.Run(() => datos.getTable("Operador"));
            dataGridView1.DataSource = datos.tabla;
            cambiando = false;
        }

        private async Task getMaquinas()
        {
            await Task.Run(() => datos.getTable("Maquinas"));
            dataGridView1.DataSource = datos.tabla;
            cambiando = false;
        }

        private void Maquina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregar.Visible = false;
            btnActualizar.Visible = true;
            btnRegresar.Visible = true;
            //realizar un control 
            try
            {
                key = (string)dataGridView1[0, e.RowIndex].Value;
                tbNombre.Text = (string)dataGridView1[0, e.RowIndex].Value;
                numProduccion.Value = (decimal)dataGridView1[1, e.RowIndex].Value;
                tbTipoEstudio.Text = (string)dataGridView1[2, e.RowIndex].Value;
                tbSerie.Text = (string)dataGridView1[3, e.RowIndex].Value;
                numAncho.Value = (int)dataGridView1[4, e.RowIndex].Value;
                numAncho.Value = (int)dataGridView1[5, e.RowIndex].Value;
            }
            catch (Exception)
            {
                tbNombre.Text = "";
                numProduccion.Value = 0;
                tbTipoEstudio.Text = "";
                tbSerie.Text = "";
                numAncho.Value = 0;
                numAncho.Value = 0;
                return;
            }
        }

        private void Operador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                key = (string)dataGridView1[0, e.RowIndex].Value;
                tbNombre.Text = (string)dataGridView1[0, e.RowIndex].Value;
                tbTipoEstudio.Text = (string)dataGridView1[1, e.RowIndex].Value;
            }
            catch (Exception)
            {
                tbNombre.Text = "";
                tbTipoEstudio.Text = "";
                return;
            }
            btnAgregar.Visible = false;
            btnActualizar.Visible = true;
            btnRegresar.Visible = true;
        }

        private void Mecanico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                key = (string)dataGridView1[0, e.RowIndex].Value;
                tbNombre.Text = (string)dataGridView1[0, e.RowIndex].Value;
                tbTipoEstudio.Text = (string)dataGridView1[1, e.RowIndex].Value;
                dtpEdad.Value = (DateTime)dataGridView1[2, e.RowIndex].Value;
            }
            catch (Exception)
            {
                tbNombre.Text = "";
                tbTipoEstudio.Text = "";
                dtpEdad.Value = DateTime.Now;
                return;
            }

            btnAgregar.Visible = false;
            btnActualizar.Visible = true;
            btnRegresar.Visible = true;
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            btnAgregar.Visible = !btnAgregar.Visible;
            btnActualizar.Visible = !btnActualizar.Visible;
            btnRegresar.Visible = !btnRegresar.Visible;
            tbNombre.Text = "";
            tbTipoEstudio.Text = "";
            tbSerie.Text = "";
            numAlto.Value = 0;
            numAncho.Value = 0;
            dtpEdad.Value = DateTime.Now;
            numProduccion.Value = 0;
        }

        private void ResetMecanico()
        {
            lblNombre.Text = "Nombre";
            tbNombre.Text = "";
            lblTipoEstudio.Text = "Estudios";
            tbTipoEstudio.Text = "";
            lblEtiqueta.Visible = true;
            lblEtiqueta.Text = "Fecha de Nacimiento";
            dtpEdad.Visible = true ;

        }

        private void ResetMaquina()
        {
            lblNombre.Text = "Modelo";
            tbNombre.Text = "";
            lblTipoEstudio.Text = "Tipo de Maquinaria";
            tbTipoEstudio.Text = "";
            lblTiempo.Visible = true;
            numProduccion.Value = 0;
            lblEtiqueta.Visible= true;
            lblEtiqueta.Text = "Etiqueta";
            numAlto.Visible = true;
            numAlto.Value = 0;
            numAncho.Visible = true;
            numAncho.Value = 0;
            lblSerie.Visible = true;
            tbSerie.Visible = true;
            tbSerie.Text = "";
            numProduccion.Visible = true;
            
        }

        private void ResetOperador()
        {
            lblNombre.Text = "Nombre";
            tbNombre.Text = "";
            lblTipoEstudio.Text = "Tipo de Maquinaria";
            tbTipoEstudio.Text = "";
        }

        private void ocultar()
        {
            dtpEdad.Visible = false;
            numAlto.Visible = false;
            numAncho.Visible = false;
            lblEtiqueta.Visible = false;
            lblPor.Visible = false;
            lblTiempo.Visible = false;
            numProduccion.Visible = false;
            tbSerie.Visible = false;
            lblSerie.Visible = false ;
        }
    }
}
