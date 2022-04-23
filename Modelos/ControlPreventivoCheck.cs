using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBD.Logica;
using System.Windows.Forms;
using System.Globalization;

namespace ProyectoBD.Modelos
{
    public partial class ControlPreventivoCheck : UserControl
    {
        private PreventivoCheck update;
        private PreventivoData datos;
        private bool reagendable;
        public FormConcentrado Parent;

        public ControlPreventivoCheck(PreventivoData datos, List<string> mecanicos)
         {
            InitializeComponent();
            this.datos = datos;

            lblMaquina.Text = datos.Maquina;
            lblPlan.Text = datos.Plan;
            lblSemana.Text = "Semana " + datos.Semana;
            listaMecanicos.DataSource = mecanicos;
            lblPostSemana.Text = "Semana ?";
            update = new PreventivoCheck(datos.Folio);
            Enabled = (datos.Active == 1 ? true : false);
        }

        public void UpdateData(PreventivoData datos) 
        {
            
            this.datos = datos;

            lblMaquina.Text = datos.Maquina;
            lblPlan.Text = datos.Plan;
            lblSemana.Text = "Semana " + datos.Semana;
            lblPostSemana.Text = "Semana ?";
            cbReagendar.Checked = false;
            update = new PreventivoCheck(datos.Folio);
            Enabled = (datos.Active == 1 ? true : false);
        }

        //metodos Privados
        private void checkBox1_CheckedChanged(object sender, EventArgs e){
           panelReagendar.Visible = cbReagendar.Checked;
           ControlEnable(!cbReagendar.Checked);
            if (!cbReagendar.Checked) 
            {
                dtpPosponer.Value = DateTime.Now;
                lblPostSemana.Text = "Semana ?";
                reagendable = false;
            }
            
        }

        private void ControlEnable(bool b){
            numParada.Enabled = b;
            numReparacion.Enabled = b;
            btnConfirmar.Enabled = b;
            listaMecanicos.Enabled = b;
            
        }
        
        private void dtpPosponer_ValueChanged(object sender, EventArgs e){
           
            lblPostSemana.Text = "Semana " + CultureInfo.CurrentCulture.Calendar.GetWeekOfYear((DateTime)dtpPosponer.Value, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
            reagendable = true;
        }
    
        private void btnReajendar_Click(object sender, EventArgs e)
        {
            if (reagendable && System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Reagendar", "Seguro que quiere Reagendar?", MessageBoxButtons.YesNo))
            {
                update.Reagendar(dtpPosponer.Value);
                if (datos.Semana > CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday))
                {
                    MessageBox.Show("Al reiniciar este preventivo ingresado ya no aparecera");
                }
            }
            
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (listaMecanicos.SelectedIndex == 0 || listaMecanicos.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un Mecanico");
                return;
            }
            if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Confirma los Datos", "Los datos puestos son Correctos?", MessageBoxButtons.YesNo))
            {
                update.Upload(numReparacion.Value, numParada.Value, listaMecanicos.Text,DateTime.Now);
                if (CultureInfo.CurrentCulture.Calendar.GetWeekOfYear((DateTime)dtpPosponer.Value, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday) > CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday))
                {
                    Parent.deletepanel(this);
                    
                }
            }
                
        }

    }
}

  