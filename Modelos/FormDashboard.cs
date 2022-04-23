﻿using System;
using ProyectoBD.Logica;
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
    public partial class FormDashboard : Form
    {
        // campos
        private Dashboard datos;
        private bool reloadData = true;
        //Constructor
        public FormDashboard()
        {
            InitializeComponent();
            
            //Default La ultima semana
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;

            datos = new Dashboard();
            loadData();
        }

        private void loadData()
        {
            if (reloadData)
            {
                datos.LoadData(dtpStartDate.Value, dtpEndDate.Value);

                tablaHrsParada.DataSource = datos.hrsParo;
                tablaHrsParada.Columns[0].HeaderText = "Maquina";
                tablaHrsParada.Columns[1].HeaderText = "Horas Parada";

                chartPareto.DataSource = datos.hrsParoChart;
                chartPareto.Series[0].XValueMember = "Maquina";
                chartPareto.Series[0].YValueMembers = "Horas";
                chartPareto.Series[1].YValueMembers = "Porcentaje";
                chartPareto.DataBind();

                chartDisponibilidad.DataSource = datos.dispoChart;
                chartDisponibilidad.Series[0].XValueMember = "Fecha";
                chartDisponibilidad.Series[0].YValueMembers = "Porcentaje";
                chartDisponibilidad.Series[1].YValueMembers = "Porcentaje";
                chartDisponibilidad.DataBind();
            }
            else 
            {
                MessageBox.Show("Carga en proceso");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOk.Visible = true;
        }
        
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOk.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            loadData();
            DisableCustomDates();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1);
            dtpEndDate.Value = DateTime.Now;
            loadData();
            DisableCustomDates();
        }
    }
}