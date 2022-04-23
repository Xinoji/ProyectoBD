namespace ProyectoBD.Modelos
{
    partial class FormConcentrado
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.ListaMaquinas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPreventivo = new System.Windows.Forms.Button();
            this.btnCorrectivo = new System.Windows.Forms.Button();
            this.lblTitleReporte = new System.Windows.Forms.Label();
            this.ListaOperador = new System.Windows.Forms.ComboBox();
            this.ListaTipo = new System.Windows.Forms.ComboBox();
            this.listaMecanicos = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.vScrollBar1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(1584, 861);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 837);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(428, 9);
            this.vScrollBar1.Maximum = 0;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 839);
            this.vScrollBar1.TabIndex = 2;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFin);
            this.panel2.Controls.Add(this.lblFechaInicio);
            this.panel2.Controls.Add(this.ListaMaquinas);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnPreventivo);
            this.panel2.Controls.Add(this.btnCorrectivo);
            this.panel2.Controls.Add(this.lblTitleReporte);
            this.panel2.Controls.Add(this.ListaOperador);
            this.panel2.Controls.Add(this.ListaTipo);
            this.panel2.Controls.Add(this.listaMecanicos);
            this.panel2.Controls.Add(this.dtpEndDate);
            this.panel2.Controls.Add(this.dtpStartDate);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 845);
            this.panel2.TabIndex = 7;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(895, 56);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(21, 13);
            this.lblFin.TabIndex = 21;
            this.lblFin.Text = "Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(664, 63);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(32, 13);
            this.lblFechaInicio.TabIndex = 20;
            this.lblFechaInicio.Text = "Inicio";
            // 
            // ListaMaquinas
            // 
            this.ListaMaquinas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ListaMaquinas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ListaMaquinas.FormattingEnabled = true;
            this.ListaMaquinas.Location = new System.Drawing.Point(145, 78);
            this.ListaMaquinas.Name = "ListaMaquinas";
            this.ListaMaquinas.Size = new System.Drawing.Size(130, 21);
            this.ListaMaquinas.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1108, 699);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(533, 114);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPreventivo
            // 
            this.btnPreventivo.Location = new System.Drawing.Point(927, 37);
            this.btnPreventivo.Name = "btnPreventivo";
            this.btnPreventivo.Size = new System.Drawing.Size(173, 23);
            this.btnPreventivo.TabIndex = 15;
            this.btnPreventivo.Text = "Agregar Preventivo";
            this.btnPreventivo.UseVisualStyleBackColor = true;
            this.btnPreventivo.Click += new System.EventHandler(this.btnPreventivo_Click);
            // 
            // btnCorrectivo
            // 
            this.btnCorrectivo.Location = new System.Drawing.Point(927, 8);
            this.btnCorrectivo.Name = "btnCorrectivo";
            this.btnCorrectivo.Size = new System.Drawing.Size(173, 23);
            this.btnCorrectivo.TabIndex = 14;
            this.btnCorrectivo.Text = "Agregar Correctivo";
            this.btnCorrectivo.UseVisualStyleBackColor = true;
            this.btnCorrectivo.Click += new System.EventHandler(this.btnCorrectivo_Click);
            // 
            // lblTitleReporte
            // 
            this.lblTitleReporte.AutoSize = true;
            this.lblTitleReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleReporte.Location = new System.Drawing.Point(527, 8);
            this.lblTitleReporte.Name = "lblTitleReporte";
            this.lblTitleReporte.Size = new System.Drawing.Size(146, 31);
            this.lblTitleReporte.TabIndex = 13;
            this.lblTitleReporte.Text = "REPORTE";
            // 
            // ListaOperador
            // 
            this.ListaOperador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ListaOperador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ListaOperador.FormattingEnabled = true;
            this.ListaOperador.Location = new System.Drawing.Point(446, 78);
            this.ListaOperador.Name = "ListaOperador";
            this.ListaOperador.Size = new System.Drawing.Size(121, 21);
            this.ListaOperador.TabIndex = 11;
            // 
            // ListaTipo
            // 
            this.ListaTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ListaTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ListaTipo.FormattingEnabled = true;
            this.ListaTipo.Location = new System.Drawing.Point(3, 78);
            this.ListaTipo.Name = "ListaTipo";
            this.ListaTipo.Size = new System.Drawing.Size(121, 21);
            this.ListaTipo.TabIndex = 10;
            // 
            // listaMecanicos
            // 
            this.listaMecanicos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaMecanicos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaMecanicos.FormattingEnabled = true;
            this.listaMecanicos.Location = new System.Drawing.Point(296, 78);
            this.listaMecanicos.Name = "listaMecanicos";
            this.listaMecanicos.Size = new System.Drawing.Size(121, 21);
            this.listaMecanicos.TabIndex = 9;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(834, 78);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(603, 79);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 7;
            // 
            // FormConcentrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormConcentrado";
            this.Text = "FormConcentrado";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleReporte;
        private System.Windows.Forms.ComboBox ListaOperador;
        private System.Windows.Forms.ComboBox ListaTipo;
        private System.Windows.Forms.ComboBox listaMecanicos;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnPreventivo;
        private System.Windows.Forms.Button btnCorrectivo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ListaMaquinas;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblFechaInicio;
    }
}