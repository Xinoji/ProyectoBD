namespace ProyectoBD.Modelos
{
    partial class FormIngresa
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
            this.btnMecanico = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMaquina = new System.Windows.Forms.Button();
            this.btnOperador = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.llenado = new System.Windows.Forms.Panel();
            this.dtpEdad = new System.Windows.Forms.DateTimePicker();
            this.numProduccion = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.numAlto = new System.Windows.Forms.NumericUpDown();
            this.lblPor = new System.Windows.Forms.Label();
            this.numAncho = new System.Windows.Forms.NumericUpDown();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.tbSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.tbTipoEstudio = new System.Windows.Forms.TextBox();
            this.lblTipoEstudio = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.llenado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAncho)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMecanico
            // 
            this.btnMecanico.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMecanico.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMecanico.Location = new System.Drawing.Point(0, 0);
            this.btnMecanico.Name = "btnMecanico";
            this.btnMecanico.Size = new System.Drawing.Size(357, 29);
            this.btnMecanico.TabIndex = 0;
            this.btnMecanico.Text = "Mecanico";
            this.btnMecanico.UseVisualStyleBackColor = true;
            this.btnMecanico.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMaquina);
            this.panel1.Controls.Add(this.btnOperador);
            this.panel1.Controls.Add(this.btnMecanico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 29);
            this.panel1.TabIndex = 1;
            // 
            // btnMaquina
            // 
            this.btnMaquina.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMaquina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaquina.Location = new System.Drawing.Point(357, 0);
            this.btnMaquina.Name = "btnMaquina";
            this.btnMaquina.Size = new System.Drawing.Size(343, 29);
            this.btnMaquina.TabIndex = 2;
            this.btnMaquina.Text = "Maquina";
            this.btnMaquina.UseVisualStyleBackColor = true;
            this.btnMaquina.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnOperador
            // 
            this.btnOperador.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOperador.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOperador.Location = new System.Drawing.Point(700, 0);
            this.btnOperador.Name = "btnOperador";
            this.btnOperador.Size = new System.Drawing.Size(362, 29);
            this.btnOperador.TabIndex = 1;
            this.btnOperador.Text = "Operador";
            this.btnOperador.UseVisualStyleBackColor = true;
            this.btnOperador.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 421);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Controls.Add(this.llenado);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(764, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 421);
            this.panel2.TabIndex = 3;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(68, 380);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(227, 38);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(3, 380);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(59, 38);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // llenado
            // 
            this.llenado.Controls.Add(this.dtpEdad);
            this.llenado.Controls.Add(this.numProduccion);
            this.llenado.Controls.Add(this.lblTiempo);
            this.llenado.Controls.Add(this.numAlto);
            this.llenado.Controls.Add(this.lblPor);
            this.llenado.Controls.Add(this.numAncho);
            this.llenado.Controls.Add(this.lblEtiqueta);
            this.llenado.Controls.Add(this.tbSerie);
            this.llenado.Controls.Add(this.lblSerie);
            this.llenado.Controls.Add(this.tbTipoEstudio);
            this.llenado.Controls.Add(this.lblTipoEstudio);
            this.llenado.Controls.Add(this.tbNombre);
            this.llenado.Controls.Add(this.lblNombre);
            this.llenado.Location = new System.Drawing.Point(3, 6);
            this.llenado.Name = "llenado";
            this.llenado.Size = new System.Drawing.Size(292, 368);
            this.llenado.TabIndex = 1;
            // 
            // dtpEdad
            // 
            this.dtpEdad.Location = new System.Drawing.Point(18, 175);
            this.dtpEdad.Name = "dtpEdad";
            this.dtpEdad.Size = new System.Drawing.Size(265, 20);
            this.dtpEdad.TabIndex = 12;
            // 
            // numProduccion
            // 
            this.numProduccion.Location = new System.Drawing.Point(18, 231);
            this.numProduccion.Name = "numProduccion";
            this.numProduccion.Size = new System.Drawing.Size(265, 20);
            this.numProduccion.TabIndex = 11;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(3, 215);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(144, 13);
            this.lblTiempo.TabIndex = 10;
            this.lblTiempo.Text = "Tiempo de Produccion Diario";
            // 
            // numAlto
            // 
            this.numAlto.Location = new System.Drawing.Point(172, 175);
            this.numAlto.Name = "numAlto";
            this.numAlto.Size = new System.Drawing.Size(111, 20);
            this.numAlto.TabIndex = 9;
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Location = new System.Drawing.Point(143, 177);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(14, 13);
            this.lblPor.TabIndex = 8;
            this.lblPor.Text = "X";
            // 
            // numAncho
            // 
            this.numAncho.Location = new System.Drawing.Point(18, 175);
            this.numAncho.Name = "numAncho";
            this.numAncho.Size = new System.Drawing.Size(110, 20);
            this.numAncho.TabIndex = 7;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(3, 159);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(46, 13);
            this.lblEtiqueta.TabIndex = 6;
            this.lblEtiqueta.Text = "Etiqueta";
            // 
            // tbSerie
            // 
            this.tbSerie.Location = new System.Drawing.Point(6, 125);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.Size = new System.Drawing.Size(277, 20);
            this.tbSerie.TabIndex = 5;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(3, 109);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(86, 13);
            this.lblSerie.TabIndex = 4;
            this.lblSerie.Text = "Numero de Serie";
            // 
            // tbTipoEstudio
            // 
            this.tbTipoEstudio.Location = new System.Drawing.Point(6, 75);
            this.tbTipoEstudio.Name = "tbTipoEstudio";
            this.tbTipoEstudio.Size = new System.Drawing.Size(277, 20);
            this.tbTipoEstudio.TabIndex = 3;
            // 
            // lblTipoEstudio
            // 
            this.lblTipoEstudio.AutoSize = true;
            this.lblTipoEstudio.Location = new System.Drawing.Point(3, 59);
            this.lblTipoEstudio.Name = "lblTipoEstudio";
            this.lblTipoEstudio.Size = new System.Drawing.Size(98, 13);
            this.lblTipoEstudio.TabIndex = 2;
            this.lblTipoEstudio.Text = "Tipo de Maquinaria";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(6, 25);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(277, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblNombre.Location = new System.Drawing.Point(3, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(3, 380);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(292, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 421);
            this.panel3.TabIndex = 4;
            // 
            // FormIngresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormIngresa";
            this.Text = "FormIngresa";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.llenado.ResumeLayout(false);
            this.llenado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAlto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAncho)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMecanico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMaquina;
        private System.Windows.Forms.Button btnOperador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel llenado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox tbSerie;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox tbTipoEstudio;
        private System.Windows.Forms.Label lblTipoEstudio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DateTimePicker dtpEdad;
        private System.Windows.Forms.NumericUpDown numProduccion;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.NumericUpDown numAlto;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.NumericUpDown numAncho;
    }
}