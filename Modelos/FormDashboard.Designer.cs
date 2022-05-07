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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea41 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend41 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series81 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series82 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle241 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle242 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle243 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle244 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle245 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle246 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle247 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle248 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle249 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle250 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle251 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle252 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea42 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend42 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series83 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series84 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tablaHrsParada = new System.Windows.Forms.DataGridView();
            this.chartPareto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSemana = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tablaA = new System.Windows.Forms.DataGridView();
            this.tablaB = new System.Windows.Forms.DataGridView();
            this.tablaC = new System.Windows.Forms.DataGridView();
            this.tablaD = new System.Windows.Forms.DataGridView();
            this.chartDisponibilidad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaHrsParada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPareto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDisponibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaHrsParada
            // 
            this.tablaHrsParada.AllowUserToAddRows = false;
            this.tablaHrsParada.AllowUserToDeleteRows = false;
            this.tablaHrsParada.AllowUserToResizeColumns = false;
            this.tablaHrsParada.AllowUserToResizeRows = false;
            this.tablaHrsParada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaHrsParada.BackgroundColor = System.Drawing.Color.White;
            this.tablaHrsParada.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaHrsParada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaHrsParada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaHrsParada.EnableHeadersVisualStyles = false;
            this.tablaHrsParada.Location = new System.Drawing.Point(724, 551);
            this.tablaHrsParada.Name = "tablaHrsParada";
            this.tablaHrsParada.RowHeadersVisible = false;
            this.tablaHrsParada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaHrsParada.Size = new System.Drawing.Size(848, 298);
            this.tablaHrsParada.TabIndex = 1;
            // 
            // chartPareto
            // 
            chartArea41.AxisX.Interval = 1D;
            chartArea41.AxisX.LabelStyle.IsStaggered = true;
            chartArea41.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea41.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea41.AxisY2.InterlacedColor = System.Drawing.Color.White;
            chartArea41.AxisY2.IsMarginVisible = false;
            chartArea41.AxisY2.LineWidth = 0;
            chartArea41.AxisY2.Maximum = 100D;
            chartArea41.AxisY2.Minimum = 0D;
            chartArea41.Name = "ChartArea1";
            this.chartPareto.ChartAreas.Add(chartArea41);
            legend41.Enabled = false;
            legend41.Name = "Legend1";
            this.chartPareto.Legends.Add(legend41);
            this.chartPareto.Location = new System.Drawing.Point(12, 226);
            this.chartPareto.Name = "chartPareto";
            series81.ChartArea = "ChartArea1";
            series81.IsValueShownAsLabel = true;
            series81.Legend = "Legend1";
            series81.Name = "Series1";
            series81.YValuesPerPoint = 6;
            series82.ChartArea = "ChartArea1";
            series82.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series82.Legend = "Legend1";
            series82.Name = "Series2";
            series82.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartPareto.Series.Add(series81);
            this.chartPareto.Series.Add(series82);
            this.chartPareto.Size = new System.Drawing.Size(695, 623);
            this.chartPareto.TabIndex = 0;
            this.chartPareto.Text = "chart1";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "       dd MMM yy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(1013, 34);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(140, 20);
            this.dtpEndDate.TabIndex = 8;
            this.dtpEndDate.Value = new System.DateTime(2021, 11, 29, 0, 0, 0, 0);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // btnSemana
            // 
            this.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemana.ForeColor = System.Drawing.Color.Coral;
            this.btnSemana.Location = new System.Drawing.Point(1453, 29);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(119, 25);
            this.btnSemana.TabIndex = 4;
            this.btnSemana.Text = "semana";
            this.btnSemana.UseVisualStyleBackColor = true;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // btnMes
            // 
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.ForeColor = System.Drawing.Color.Coral;
            this.btnMes.Location = new System.Drawing.Point(1330, 29);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(124, 25);
            this.btnMes.TabIndex = 5;
            this.btnMes.Text = "mes";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.ForeColor = System.Drawing.Color.Coral;
            this.btnCustom.Location = new System.Drawing.Point(1211, 29);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(120, 25);
            this.btnCustom.TabIndex = 6;
            this.btnCustom.Text = "personalizado";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "       dd MMM yy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(837, 35);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(140, 20);
            this.dtpStartDate.TabIndex = 9;
            this.dtpStartDate.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // tablaA
            // 
            this.tablaA.AllowUserToAddRows = false;
            this.tablaA.AllowUserToDeleteRows = false;
            this.tablaA.AllowUserToResizeColumns = false;
            this.tablaA.AllowUserToResizeRows = false;
            this.tablaA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaA.BackgroundColor = System.Drawing.Color.White;
            this.tablaA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle241.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle241.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle241.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle241.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle241.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle241.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle241.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle241;
            this.tablaA.ColumnHeadersHeight = 20;
            this.tablaA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle242.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle242.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle242.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle242.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle242.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle242.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle242.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaA.DefaultCellStyle = dataGridViewCellStyle242;
            this.tablaA.EnableHeadersVisualStyles = false;
            this.tablaA.Location = new System.Drawing.Point(26, 85);
            this.tablaA.Name = "tablaA";
            dataGridViewCellStyle243.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle243.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle243.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle243.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle243.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle243.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle243.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaA.RowHeadersDefaultCellStyle = dataGridViewCellStyle243;
            this.tablaA.RowHeadersVisible = false;
            this.tablaA.RowTemplate.Height = 31;
            this.tablaA.Size = new System.Drawing.Size(340, 119);
            this.tablaA.TabIndex = 10;
            // 
            // tablaB
            // 
            this.tablaB.AllowUserToAddRows = false;
            this.tablaB.AllowUserToDeleteRows = false;
            this.tablaB.AllowUserToResizeColumns = false;
            this.tablaB.AllowUserToResizeRows = false;
            this.tablaB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaB.BackgroundColor = System.Drawing.Color.White;
            this.tablaB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle244.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle244.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle244.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle244.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle244.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle244.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle244.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle244;
            this.tablaB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle245.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle245.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle245.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle245.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle245.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle245.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle245.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaB.DefaultCellStyle = dataGridViewCellStyle245;
            this.tablaB.EnableHeadersVisualStyles = false;
            this.tablaB.Location = new System.Drawing.Point(424, 85);
            this.tablaB.Name = "tablaB";
            dataGridViewCellStyle246.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle246.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle246.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle246.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle246.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle246.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle246.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaB.RowHeadersDefaultCellStyle = dataGridViewCellStyle246;
            this.tablaB.RowHeadersVisible = false;
            this.tablaB.RowTemplate.Height = 31;
            this.tablaB.Size = new System.Drawing.Size(340, 119);
            this.tablaB.TabIndex = 11;
            // 
            // tablaC
            // 
            this.tablaC.AllowUserToAddRows = false;
            this.tablaC.AllowUserToDeleteRows = false;
            this.tablaC.AllowUserToResizeColumns = false;
            this.tablaC.AllowUserToResizeRows = false;
            this.tablaC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaC.BackgroundColor = System.Drawing.Color.White;
            this.tablaC.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle247.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle247.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle247.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle247.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle247.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle247.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle247.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle247;
            this.tablaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle248.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle248.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle248.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle248.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle248.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle248.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle248.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaC.DefaultCellStyle = dataGridViewCellStyle248;
            this.tablaC.EnableHeadersVisualStyles = false;
            this.tablaC.Location = new System.Drawing.Point(806, 85);
            this.tablaC.Name = "tablaC";
            dataGridViewCellStyle249.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle249.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle249.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle249.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle249.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle249.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle249.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaC.RowHeadersDefaultCellStyle = dataGridViewCellStyle249;
            this.tablaC.RowHeadersVisible = false;
            this.tablaC.RowTemplate.Height = 31;
            this.tablaC.Size = new System.Drawing.Size(340, 119);
            this.tablaC.TabIndex = 12;
            // 
            // tablaD
            // 
            this.tablaD.AllowUserToAddRows = false;
            this.tablaD.AllowUserToDeleteRows = false;
            this.tablaD.AllowUserToResizeColumns = false;
            this.tablaD.AllowUserToResizeRows = false;
            this.tablaD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaD.BackgroundColor = System.Drawing.Color.White;
            this.tablaD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle250.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle250.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle250.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle250.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle250.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle250.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle250.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle250;
            this.tablaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle251.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle251.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle251.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle251.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle251.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle251.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle251.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaD.DefaultCellStyle = dataGridViewCellStyle251;
            this.tablaD.EnableHeadersVisualStyles = false;
            this.tablaD.Location = new System.Drawing.Point(1197, 85);
            this.tablaD.Name = "tablaD";
            dataGridViewCellStyle252.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle252.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle252.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle252.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle252.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle252.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle252.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaD.RowHeadersDefaultCellStyle = dataGridViewCellStyle252;
            this.tablaD.RowHeadersVisible = false;
            this.tablaD.RowTemplate.Height = 31;
            this.tablaD.Size = new System.Drawing.Size(340, 119);
            this.tablaD.TabIndex = 13;
            // 
            // chartDisponibilidad
            // 
            this.chartDisponibilidad.BorderlineColor = System.Drawing.Color.IndianRed;
            chartArea42.AxisX.IsMarginVisible = false;
            chartArea42.AxisY.IsMarginVisible = false;
            chartArea42.Name = "ChartArea1";
            this.chartDisponibilidad.ChartAreas.Add(chartArea42);
            legend42.Enabled = false;
            legend42.Name = "Legend1";
            this.chartDisponibilidad.Legends.Add(legend42);
            this.chartDisponibilidad.Location = new System.Drawing.Point(732, 226);
            this.chartDisponibilidad.Name = "chartDisponibilidad";
            series83.ChartArea = "ChartArea1";
            series83.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series83.Legend = "Legend1";
            series83.Name = "Series1";
            series84.ChartArea = "ChartArea1";
            series84.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series84.IsValueShownAsLabel = true;
            series84.LabelFormat = "#";
            series84.Legend = "Legend1";
            series84.Name = "Series2";
            this.chartDisponibilidad.Series.Add(series83);
            this.chartDisponibilidad.Series.Add(series84);
            this.chartDisponibilidad.Size = new System.Drawing.Size(840, 319);
            this.chartDisponibilidad.TabIndex = 14;
            this.chartDisponibilidad.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Panel de Control";
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.Brown;
            this.btnOk.Location = new System.Drawing.Point(1162, 29);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(50, 25);
            this.btnOk.TabIndex = 16;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 17;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Silver;
            this.lblStartDate.Location = new System.Drawing.Point(837, 35);
            this.lblStartDate.MinimumSize = new System.Drawing.Size(140, 19);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(140, 19);
            this.lblStartDate.TabIndex = 18;
            this.lblStartDate.Text = "Texto";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStartDate.Click += new System.EventHandler(this.lblStartDate_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.White;
            this.lblEndDate.Location = new System.Drawing.Point(1013, 34);
            this.lblEndDate.MinimumSize = new System.Drawing.Size(140, 19);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(140, 19);
            this.lblEndDate.TabIndex = 19;
            this.lblEndDate.Text = "Texto";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartDisponibilidad);
            this.Controls.Add(this.tablaD);
            this.Controls.Add(this.tablaC);
            this.Controls.Add(this.tablaB);
            this.Controls.Add(this.tablaA);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.chartPareto);
            this.Controls.Add(this.tablaHrsParada);
            this.Controls.Add(this.btnSemana);
            this.Controls.Add(this.btnMes);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaHrsParada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPareto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaD)).EndInit();
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
        private System.Windows.Forms.DataGridView tablaA;
        private System.Windows.Forms.DataGridView tablaB;
        private System.Windows.Forms.DataGridView tablaC;
        private System.Windows.Forms.DataGridView tablaD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDisponibilidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
    }
}