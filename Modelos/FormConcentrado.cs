﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBD.Logica;

namespace ProyectoBD.Modelos
{
    public partial class FormConcentrado : Form
    {
        //Campos
        private List<PreventivoData> ListaPreventivo;
        private ControlPreventivoCheck[] paneles;
        private Concentrado datos;
        
        //Constructor
        public FormConcentrado()
        {
            InitializeComponent();
            
            datos = new Concentrado();
            ListaPreventivo = datos.preventivoDatas;
            paneles = new ControlPreventivoCheck[5];
            loadPreventivo();
            listaMecanicos.DataSource = datos.Mecanicos;
            ListaTipo.DataSource = datos.Tipos;
            ListaOperador.DataSource = datos.Operadores;
            ListaMaquinas.DataSource = datos.Maquinas;
            
        }

        public void deletepanel(ControlPreventivoCheck panel)
        {
            int i = 0;
            foreach (var item in paneles)
            {
                if (item == panel)
                {
                    ListaPreventivo.RemoveAt(i + vScrollBar1.Value);
                    vScrollBar1.Maximum -= 1;
                }
                if (paneles.Count() > ListaPreventivo.Count())
                {
                    int j = 0;
                    int k = 0;
                    var panelesTemp = new ControlPreventivoCheck[paneles.Count() - 1];
                    foreach (var aux in paneles)
                    {
                        if (j != i)
                        {
                            panelesTemp[k] = aux;
                            k++;
                        }
                        else
                        {
                            aux.Dispose();
                        }
                        j++;
                    }
                    
                }
                paneles[i].UpdateData(ListaPreventivo[vScrollBar1.Value + i]);
                i++;
            }
        }

        //Metodos Privados
        private void loadPreventivo()
        {
            int i = 0;
            vScrollBar1.Maximum = ListaPreventivo.Count() - 5;
           if (vScrollBar1.Maximum < 1)
                vScrollBar1.Visible = false;

            while (i < paneles.Count() && i < ListaPreventivo.Count())
            {
                paneles[i] = new ControlPreventivoCheck(ListaPreventivo[i], datos.Mecanicos);
                paneles[i].Parent = this;
                tableLayoutPanel1.Controls.Add(paneles[i]);

                i++;
            }

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int i = 0;
            foreach (var item in paneles) 
            {
                item.UpdateData(ListaPreventivo[e.NewValue + i]);
                i++;
            }
            
        }

        private async void btnSearch_Click(object sender, EventArgs e) {
            DataTable dt = new DataTable();
            //MessageBox.Show(ListaMaquinas.SelectedValue.ToString() + " " + listaMecanicos.SelectedValue.ToString() + " " + ListaOperador.SelectedValue.ToString() + " " + ListaTipo.SelectedValue.ToString() + " " + dtpStartDate.Value.ToString() + " " + dtpEndDate.Value.ToString());

            if (ListaMaquinas.SelectedValue != null && listaMecanicos.SelectedValue != null && ListaOperador.SelectedValue != null && ListaTipo.SelectedValue != null)
            {
                await getReparaciones(ListaMaquinas.SelectedValue.ToString(), listaMecanicos.SelectedValue.ToString(), ListaOperador.SelectedValue.ToString(), ListaTipo.SelectedValue.ToString(), dtpStartDate.Value, dtpEndDate.Value, dataGridView1);
                await Task.Run(() => dt = datos.Reparacion);
                dataGridView1.DataSource = dt;
            }
            
        }

        private async Task getReparaciones(string maquina, string mecanico, string operador, string tipo, DateTime startDate, DateTime endDate, DataGridView tabla)
        {
            await Task.Run  (() =>  datos.getReparaciones(maquina,mecanico,operador,tipo,startDate,endDate));

        }

        private void btnCorrectivo_Click(object sender, EventArgs e)
        {
            FormLlenado formLlenado = new FormLlenado();
            formLlenado.Show();
            
        }
            


        private void btnPreventivo_Click(object sender, EventArgs e)
        {
            FormPreventivo formPreventivo = new FormPreventivo();
            formPreventivo.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormLlenado formLlenado = new FormLlenado((int)dataGridView1[0, e.RowIndex].Value);
                formLlenado.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione, una celda, no una columna");
                
            }
            
        }
    }
}
