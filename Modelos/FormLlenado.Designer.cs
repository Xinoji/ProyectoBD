namespace ProyectoBD.Modelos
{
    partial class FormLlenado
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
            this.listaMaquinas = new System.Windows.Forms.ComboBox();
            this.listaMecanico = new System.Windows.Forms.ComboBox();
            this.listaOperador = new System.Windows.Forms.ComboBox();
            this.numParada = new System.Windows.Forms.NumericUpDown();
            this.numReparacion = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.Causa = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.TextBox();
            this.btnSubir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numParada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // listaMaquinas
            // 
            this.listaMaquinas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.listaMaquinas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.listaMaquinas.Location = new System.Drawing.Point(220, 11);
            this.listaMaquinas.Name = "listaMaquinas";
            this.listaMaquinas.Size = new System.Drawing.Size(311, 21);
            this.listaMaquinas.TabIndex = 0;
            // 
            // listaMecanico
            // 
            this.listaMecanico.FormattingEnabled = true;
            this.listaMecanico.Location = new System.Drawing.Point(252, 54);
            this.listaMecanico.Name = "listaMecanico";
            this.listaMecanico.Size = new System.Drawing.Size(121, 21);
            this.listaMecanico.TabIndex = 1;
            // 
            // listaOperador
            // 
            this.listaOperador.FormattingEnabled = true;
            this.listaOperador.Location = new System.Drawing.Point(4, 161);
            this.listaOperador.Name = "listaOperador";
            this.listaOperador.Size = new System.Drawing.Size(121, 21);
            this.listaOperador.TabIndex = 2;
            // 
            // numParada
            // 
            this.numParada.Location = new System.Drawing.Point(12, 55);
            this.numParada.Name = "numParada";
            this.numParada.Size = new System.Drawing.Size(91, 20);
            this.numParada.TabIndex = 3;
            // 
            // numReparacion
            // 
            this.numReparacion.Location = new System.Drawing.Point(109, 55);
            this.numReparacion.Name = "numReparacion";
            this.numReparacion.Size = new System.Drawing.Size(103, 20);
            this.numReparacion.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(12, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 5;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(4, 108);
            this.Descripcion.MaxLength = 100;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(527, 20);
            this.Descripcion.TabIndex = 6;
            // 
            // Causa
            // 
            this.Causa.Location = new System.Drawing.Point(131, 162);
            this.Causa.Name = "Causa";
            this.Causa.Size = new System.Drawing.Size(151, 20);
            this.Causa.TabIndex = 7;
            // 
            // s
            // 
            this.s.Location = new System.Drawing.Point(288, 162);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(163, 20);
            this.s.TabIndex = 8;
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(4, 201);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(527, 42);
            this.btnSubir.TabIndex = 9;
            this.btnSubir.Text = "button1";
            this.btnSubir.UseVisualStyleBackColor = true;
            // 
            // FormLlenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 250);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.s);
            this.Controls.Add(this.Causa);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.numReparacion);
            this.Controls.Add(this.numParada);
            this.Controls.Add(this.listaOperador);
            this.Controls.Add(this.listaMecanico);
            this.Controls.Add(this.listaMaquinas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLlenado";
            this.Text = "FormLlenado";
            ((System.ComponentModel.ISupportInitialize)(this.numParada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReparacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listaMaquinas;
        private System.Windows.Forms.ComboBox listaMecanico;
        private System.Windows.Forms.ComboBox listaOperador;
        private System.Windows.Forms.NumericUpDown numParada;
        private System.Windows.Forms.NumericUpDown numReparacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox Causa;
        private System.Windows.Forms.TextBox s;
        private System.Windows.Forms.Button btnSubir;
    }
}