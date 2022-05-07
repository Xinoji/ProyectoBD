using System;
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
        private Button botonActual;


        //Constructor
        public FormDashboard()
        {
            InitializeComponent();
            setTheme();


            //Default La ultima semana
            dtpStartDate.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1);
            dtpEndDate.Value = DateTime.Now;

            datos = new Dashboard();
            try
            {

                loadData();
                changeActive(btnSemana);
            }
            catch (Exception)
            {
                MessageBox.Show("no hay datos");
            }
            
        }

        private async Task setTheme()
        {
            var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);
            var lightlight = ControlPaint.LightLight(themeColor);
            var lightdarkdarkColor = ControlPaint.Light(ControlPaint.Dark(darkColor));
            var darklightlight = ControlPaint.Dark(lightlight);
            var lightlightInvert = ControlPaint.LightLight(ControlPaint.Dark(WinTheme.InvertMeAColour(themeColor)));

            //botones
            btnMes.BackColor = darkColor;
            btnMes.ForeColor = lightlight;
            btnMes.FlatAppearance.BorderColor = themeColor;
            btnSemana.BackColor = darkColor;
            btnSemana.ForeColor = lightlight;
            btnSemana.FlatAppearance.BorderColor = themeColor;
            btnCustom.BackColor = darkColor;
            btnCustom.ForeColor = lightlight;
            btnCustom.FlatAppearance.BorderColor = themeColor;

            btnOk.BackColor = lightlightInvert;
            btnOk.ForeColor = Color.White;

            //graficas
            BackColor = darkColor;
            ForeColor = Color.White;
            lblStartDate.ForeColor = Color.White;
            
            chartPareto.BackColor = lightdarkdarkColor;
            chartPareto.ChartAreas[0].BackColor = lightdarkdarkColor;
            chartPareto.ChartAreas[0].AxisX.LineColor = Color.Snow;
            chartPareto.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chartPareto.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.White;
            chartPareto.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            chartPareto.Series[0].LabelForeColor = Color.White;
            chartPareto.Series[0].Color = lightlight;
            chartPareto.Series[1].Color = lightlightInvert;

            chartPareto.ChartAreas[0].AxisY2.LineColor = Color.White;
            chartPareto.ChartAreas[0].AxisY2.MajorGrid.LineColor = Color.White;
            chartPareto.ChartAreas[0].AxisY2.MajorTickMark.LineColor = Color.White;
            chartPareto.ChartAreas[0].AxisY2.LabelStyle.ForeColor = Color.White;


            chartDisponibilidad.BackColor = lightdarkdarkColor;
            chartDisponibilidad.ChartAreas[0].BackColor = lightdarkdarkColor;
            chartDisponibilidad.ChartAreas[0].AxisX.LineColor = Color.Snow;
            chartDisponibilidad.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chartDisponibilidad.ChartAreas[0].AxisX.MajorTickMark.LineColor = Color.White;
            chartDisponibilidad.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            chartDisponibilidad.Series[1].LabelForeColor = Color.White;
            chartDisponibilidad.Series[0].Color = lightlight;
            chartDisponibilidad.Series[1].Color = lightlightInvert;

            chartDisponibilidad.ChartAreas[0].AxisY.LineColor = Color.White;
            chartDisponibilidad.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chartDisponibilidad.ChartAreas[0].AxisY.MajorTickMark.LineColor = Color.White;
            chartDisponibilidad.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            chartDisponibilidad.BackColor = lightdarkdarkColor;

            //tablas
            tablaA.BackgroundColor = lightdarkdarkColor;
            tablaA.DefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaA.DefaultCellStyle.ForeColor = Color.Silver;
            tablaA.DefaultCellStyle.SelectionForeColor = Color.White;
            tablaA.DefaultCellStyle.SelectionBackColor = lightlightInvert;
            
            tablaA.ColumnHeadersDefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaA.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            tablaA.ColumnHeadersDefaultCellStyle.SelectionBackColor = lightlightInvert;
            
            tablaA.GridColor = darkColor;

            tablaB.BackgroundColor = lightdarkdarkColor;
            tablaB.DefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaB.DefaultCellStyle.ForeColor = Color.Silver;
            tablaB.DefaultCellStyle.SelectionForeColor = Color.White;
            tablaB.DefaultCellStyle.SelectionBackColor = lightlightInvert;

            tablaB.ColumnHeadersDefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaB.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaB.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            tablaB.ColumnHeadersDefaultCellStyle.SelectionBackColor = lightlightInvert;

            tablaB.GridColor = darkColor;

            tablaC.BackgroundColor = lightdarkdarkColor;
            tablaC.DefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaC.DefaultCellStyle.ForeColor = Color.Silver;
            tablaC.DefaultCellStyle.SelectionForeColor = Color.White;
            tablaC.DefaultCellStyle.SelectionBackColor = lightlightInvert;
            tablaC.ColumnHeadersDefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaC.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            tablaC.ColumnHeadersDefaultCellStyle.SelectionBackColor = lightlightInvert;

            tablaC.GridColor = darkColor;

            tablaD.BackgroundColor = lightdarkdarkColor;
            tablaD.DefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaD.DefaultCellStyle.ForeColor = Color.Silver;
            tablaD.DefaultCellStyle.SelectionForeColor = Color.White;
            tablaD.DefaultCellStyle.SelectionBackColor = lightlightInvert;
            tablaD.ColumnHeadersDefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaD.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaD.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            tablaD.ColumnHeadersDefaultCellStyle.SelectionBackColor = lightlightInvert;

            tablaD.GridColor = darkColor;

            tablaHrsParada.BackgroundColor = lightdarkdarkColor;
            tablaHrsParada.DefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaHrsParada.DefaultCellStyle.ForeColor = Color.Silver;
            tablaHrsParada.DefaultCellStyle.SelectionForeColor = Color.White;
            tablaHrsParada.DefaultCellStyle.SelectionBackColor = lightlightInvert;

            tablaHrsParada.ColumnHeadersDefaultCellStyle.BackColor = lightdarkdarkColor;
            tablaHrsParada.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tablaHrsParada.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            tablaHrsParada.ColumnHeadersDefaultCellStyle.SelectionBackColor = lightlightInvert;

            tablaA.GridColor = darkColor;
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

                tablaA.DataSource = datos.planA;
                tablaB.DataSource = datos.planB;
                tablaC.DataSource = datos.planC;
                tablaD.DataSource = datos.planD;

                

            }
            else 
            {
                MessageBox.Show("Carga en proceso");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnOk.Visible = true;
            changeActive(sender);
        }
        
        private void changeActive(object button)
        {
            var btn = (Button)button;
            btn.BackColor = WinTheme.GetAccentColor();
            btn.ForeColor = Color.White;
            //dtpStartDate.Enabled = false;
            //dtpEndDate.Enabled = false;
            //btnOk.Visible = false;
            if (botonActual != btn && botonActual != null)
            {
                botonActual.BackColor = BackColor;
                botonActual.ForeColor = ControlPaint.Light(WinTheme.GetAccentColor());
            }
            botonActual = btn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            btnOk.Visible = false;
            loadData();
            changeActive(sender);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1);
            dtpEndDate.Value = DateTime.Now;
            btnOk.Visible = false;
            loadData();
            changeActive(sender);
        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {
            if (botonActual == btnCustom)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {
            if (botonActual == btnCustom)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            lblEndDate.Text = dtpEndDate.Text;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lblStartDate.Text = dtpStartDate.Text;
            lblEndDate.Text = dtpEndDate.Text;
            tablaHrsParada.Columns[1].Width = 100;

        }
    }
}
