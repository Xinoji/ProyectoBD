namespace ProyectoBD.Modelos
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tablaHrsParada = new System.Windows.Forms.DataGridView();
            this.chartPareto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.PlanB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.planC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.planD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartDisponibilidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHrsParada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPareto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisponibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaHrsParada
            // 
            this.tablaHrsParada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaHrsParada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHrsParada.Location = new System.Drawing.Point(724, 551);
            this.tablaHrsParada.Name = "tablaHrsParada";
            this.tablaHrsParada.RowHeadersVisible = false;
            this.tablaHrsParada.Size = new System.Drawing.Size(848, 298);
            this.tablaHrsParada.TabIndex = 1;
            // 
            // chartPareto
            // 
            chartArea5.AxisX.Interval = 1D;
            chartArea5.AxisX.LabelStyle.IsStaggered = true;
            chartArea5.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY2.InterlacedColor = System.Drawing.Color.White;
            chartArea5.AxisY2.IsMarginVisible = false;
            chartArea5.AxisY2.LineWidth = 0;
            chartArea5.AxisY2.Maximum = 100D;
            chartArea5.AxisY2.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.chartPareto.ChartAreas.Add(chartArea5);
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.chartPareto.Legends.Add(legend5);
            this.chartPareto.Location = new System.Drawing.Point(12, 226);
            this.chartPareto.Name = "chartPareto";
            series9.ChartArea = "ChartArea1";
            series9.IsValueShownAsLabel = true;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series9.YValuesPerPoint = 6;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series2";
            series10.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartPareto.Series.Add(series9);
            this.chartPareto.Series.Add(series10);
            this.chartPareto.Size = new System.Drawing.Size(706, 623);
            this.chartPareto.TabIndex = 0;
            this.chartPareto.Text = "chart1";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(687, 12);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 8;
            // 
            // btnSemana
            // 
            this.btnSemana.Location = new System.Drawing.Point(1377, 12);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(200, 25);
            this.btnSemana.TabIndex = 4;
            this.btnSemana.Text = "semana";
            this.btnSemana.UseVisualStyleBackColor = true;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // btnMes
            // 
            this.btnMes.Location = new System.Drawing.Point(1171, 12);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(200, 25);
            this.btnMes.TabIndex = 5;
            this.btnMes.Text = "mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(965, 12);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(200, 25);
            this.btnCustom.TabIndex = 6;
            this.btnCustom.Text = "personalizado";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "      dddd dd/MMMM/yyyy";
            this.dtpStartDate.Location = new System.Drawing.Point(424, 12);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(207, 20);
            this.dtpStartDate.TabIndex = 9;
            this.dtpStartDate.Value = new System.DateTime(2022, 12, 14, 13, 31, 0, 0);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1});
            this.dataGridView2.Location = new System.Drawing.Point(26, 74);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(340, 130);
            this.dataGridView2.TabIndex = 10;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Plan A";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlanB});
            this.dataGridView3.Location = new System.Drawing.Point(415, 74);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(340, 130);
            this.dataGridView3.TabIndex = 11;
            // 
            // PlanB
            // 
            this.PlanB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlanB.HeaderText = "Plan B";
            this.PlanB.Name = "PlanB";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planC});
            this.dataGridView4.Location = new System.Drawing.Point(806, 74);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.Size = new System.Drawing.Size(340, 130);
            this.dataGridView4.TabIndex = 12;
            // 
            // planC
            // 
            this.planC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planC.HeaderText = "Plan C";
            this.planC.Name = "planC";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planD});
            this.dataGridView5.Location = new System.Drawing.Point(1197, 74);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.Size = new System.Drawing.Size(340, 130);
            this.dataGridView5.TabIndex = 13;
            // 
            // planD
            // 
            this.planD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.planD.HeaderText = "Plan D";
            this.planD.Name = "planD";
            // 
            // chartDisponibilidad
            // 
            chartArea6.AxisX.IsMarginVisible = false;
            chartArea6.AxisY.IsMarginVisible = false;
            chartArea6.Name = "ChartArea1";
            this.chartDisponibilidad.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartDisponibilidad.Legends.Add(legend6);
            this.chartDisponibilidad.Location = new System.Drawing.Point(724, 226);
            this.chartDisponibilidad.Name = "chartDisponibilidad";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.IsValueShownAsLabel = true;
            series12.LabelFormat = "#";
            series12.Legend = "Legend1";
            series12.Name = "Series2";
            this.chartDisponibilidad.Series.Add(series11);
            this.chartDisponibilidad.Series.Add(series12);
            this.chartDisponibilidad.Size = new System.Drawing.Size(848, 319);
            this.chartDisponibilidad.TabIndex = 14;
            this.chartDisponibilidad.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Panel de Control";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(909, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 25);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDisponibilidad);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.chartPareto);
            this.Controls.Add(this.tablaHrsParada);
            this.Controls.Add(this.btnSemana);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnMes);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.tablaHrsParada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPareto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisponibilidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaHrsParada;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPareto;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanB;
        private System.Windows.Forms.DataGridViewTextBoxColumn planC;
        private System.Windows.Forms.DataGridViewTextBoxColumn planD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDisponibilidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnOk;
    }
}