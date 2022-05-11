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
            this.select_maquina = new System.Windows.Forms.ComboBox();
            this.select_mecanico = new System.Windows.Forms.ComboBox();
            this.select_operador = new System.Windows.Forms.ComboBox();
            this.tiempo_parada = new System.Windows.Forms.NumericUpDown();
            this.tiempo_reparacion = new System.Windows.Forms.NumericUpDown();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.text_descripcion = new System.Windows.Forms.TextBox();
            this.text_causa = new System.Windows.Forms.TextBox();
            this.b_subir = new System.Windows.Forms.Button();
            this.text_solucion = new System.Windows.Forms.TextBox();
            this.l_operador = new System.Windows.Forms.Label();
            this.l_mecanico = new System.Windows.Forms.Label();
            this.l_causa = new System.Windows.Forms.Label();
            this.l_solucion = new System.Windows.Forms.Label();
            this.l_reparacion = new System.Windows.Forms.Label();
            this.l_parada = new System.Windows.Forms.Label();
            this.l_descripcion = new System.Windows.Forms.Label();
            this.l_fecha = new System.Windows.Forms.Label();
            this.l_maquina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tiempo_parada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiempo_reparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // select_maquina
            // 
            this.select_maquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.select_maquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.select_maquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_maquina.Location = new System.Drawing.Point(363, 39);
            this.select_maquina.Name = "select_maquina";
            this.select_maquina.Size = new System.Drawing.Size(123, 21);
            this.select_maquina.TabIndex = 0;
            // 
            // select_mecanico
            // 
            this.select_mecanico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_mecanico.FormattingEnabled = true;
            this.select_mecanico.Location = new System.Drawing.Point(287, 207);
            this.select_mecanico.Name = "select_mecanico";
            this.select_mecanico.Size = new System.Drawing.Size(199, 21);
            this.select_mecanico.TabIndex = 1;
            // 
            // select_operador
            // 
            this.select_operador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_operador.FormattingEnabled = true;
            this.select_operador.Location = new System.Drawing.Point(26, 206);
            this.select_operador.Name = "select_operador";
            this.select_operador.Size = new System.Drawing.Size(209, 21);
            this.select_operador.TabIndex = 2;
            // 
            // tiempo_parada
            // 
            this.tiempo_parada.Location = new System.Drawing.Point(147, 137);
            this.tiempo_parada.Name = "tiempo_parada";
            this.tiempo_parada.Size = new System.Drawing.Size(88, 20);
            this.tiempo_parada.TabIndex = 3;
            // 
            // tiempo_reparacion
            // 
            this.tiempo_reparacion.Location = new System.Drawing.Point(405, 138);
            this.tiempo_reparacion.Name = "tiempo_reparacion";
            this.tiempo_reparacion.Size = new System.Drawing.Size(79, 20);
            this.tiempo_reparacion.TabIndex = 4;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(26, 40);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 5;
            // 
            // text_descripcion
            // 
            this.text_descripcion.Location = new System.Drawing.Point(26, 95);
            this.text_descripcion.MaxLength = 100;
            this.text_descripcion.Name = "text_descripcion";
            this.text_descripcion.Size = new System.Drawing.Size(460, 20);
            this.text_descripcion.TabIndex = 6;
            // 
            // text_causa
            // 
            this.text_causa.Location = new System.Drawing.Point(26, 248);
            this.text_causa.Multiline = true;
            this.text_causa.Name = "text_causa";
            this.text_causa.Size = new System.Drawing.Size(209, 91);
            this.text_causa.TabIndex = 7;
            // 
            // b_subir
            // 
            this.b_subir.FlatAppearance.BorderSize = 0;
            this.b_subir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_subir.Location = new System.Drawing.Point(24, 370);
            this.b_subir.Name = "b_subir";
            this.b_subir.Size = new System.Drawing.Size(462, 42);
            this.b_subir.TabIndex = 9;
            this.b_subir.Text = "button1";
            this.b_subir.UseVisualStyleBackColor = true;
            // 
            // text_solucion
            // 
            this.text_solucion.Location = new System.Drawing.Point(287, 249);
            this.text_solucion.Multiline = true;
            this.text_solucion.Name = "text_solucion";
            this.text_solucion.Size = new System.Drawing.Size(199, 91);
            this.text_solucion.TabIndex = 8;
            // 
            // l_operador
            // 
            this.l_operador.AutoSize = true;
            this.l_operador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_operador.Location = new System.Drawing.Point(23, 188);
            this.l_operador.Name = "l_operador";
            this.l_operador.Size = new System.Drawing.Size(60, 15);
            this.l_operador.TabIndex = 10;
            this.l_operador.Text = "Operador";
            // 
            // l_mecanico
            // 
            this.l_mecanico.AutoSize = true;
            this.l_mecanico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mecanico.Location = new System.Drawing.Point(284, 188);
            this.l_mecanico.Name = "l_mecanico";
            this.l_mecanico.Size = new System.Drawing.Size(60, 15);
            this.l_mecanico.TabIndex = 11;
            this.l_mecanico.Text = "Mecanico";
            // 
            // l_causa
            // 
            this.l_causa.AutoSize = true;
            this.l_causa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_causa.Location = new System.Drawing.Point(23, 231);
            this.l_causa.Name = "l_causa";
            this.l_causa.Size = new System.Drawing.Size(38, 15);
            this.l_causa.TabIndex = 12;
            this.l_causa.Text = "Causa";
            // 
            // l_solucion
            // 
            this.l_solucion.AutoSize = true;
            this.l_solucion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_solucion.Location = new System.Drawing.Point(284, 231);
            this.l_solucion.Name = "l_solucion";
            this.l_solucion.Size = new System.Drawing.Size(54, 15);
            this.l_solucion.TabIndex = 13;
            this.l_solucion.Text = "Solucion";
            // 
            // l_reparacion
            // 
            this.l_reparacion.AutoSize = true;
            this.l_reparacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_reparacion.Location = new System.Drawing.Point(260, 138);
            this.l_reparacion.Name = "l_reparacion";
            this.l_reparacion.Size = new System.Drawing.Size(139, 15);
            this.l_reparacion.TabIndex = 14;
            this.l_reparacion.Text = "Tiempo en repararacion";
            // 
            // l_parada
            // 
            this.l_parada.AutoSize = true;
            this.l_parada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_parada.Location = new System.Drawing.Point(23, 138);
            this.l_parada.Name = "l_parada";
            this.l_parada.Size = new System.Drawing.Size(118, 15);
            this.l_parada.TabIndex = 15;
            this.l_parada.Text = "Tiempo en detenida";
            // 
            // l_descripcion
            // 
            this.l_descripcion.AutoSize = true;
            this.l_descripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_descripcion.Location = new System.Drawing.Point(23, 77);
            this.l_descripcion.Name = "l_descripcion";
            this.l_descripcion.Size = new System.Drawing.Size(72, 15);
            this.l_descripcion.TabIndex = 16;
            this.l_descripcion.Text = "Descripcion";
            // 
            // l_fecha
            // 
            this.l_fecha.AutoSize = true;
            this.l_fecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_fecha.Location = new System.Drawing.Point(23, 22);
            this.l_fecha.Name = "l_fecha";
            this.l_fecha.Size = new System.Drawing.Size(130, 15);
            this.l_fecha.TabIndex = 17;
            this.l_fecha.Text = "Fecha de la reparacion";
            // 
            // l_maquina
            // 
            this.l_maquina.AutoSize = true;
            this.l_maquina.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_maquina.Location = new System.Drawing.Point(360, 22);
            this.l_maquina.Name = "l_maquina";
            this.l_maquina.Size = new System.Drawing.Size(54, 15);
            this.l_maquina.TabIndex = 18;
            this.l_maquina.Text = "Maquina";
            // 
            // FormLlenado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 440);
            this.Controls.Add(this.l_maquina);
            this.Controls.Add(this.l_fecha);
            this.Controls.Add(this.l_descripcion);
            this.Controls.Add(this.l_parada);
            this.Controls.Add(this.l_reparacion);
            this.Controls.Add(this.l_solucion);
            this.Controls.Add(this.l_causa);
            this.Controls.Add(this.l_mecanico);
            this.Controls.Add(this.l_operador);
            this.Controls.Add(this.b_subir);
            this.Controls.Add(this.text_solucion);
            this.Controls.Add(this.text_causa);
            this.Controls.Add(this.text_descripcion);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.tiempo_reparacion);
            this.Controls.Add(this.tiempo_parada);
            this.Controls.Add(this.select_operador);
            this.Controls.Add(this.select_mecanico);
            this.Controls.Add(this.select_maquina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLlenado";
            this.Text = "FormLlenado";
            ((System.ComponentModel.ISupportInitialize)(this.tiempo_parada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiempo_reparacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox select_maquina;
        private System.Windows.Forms.ComboBox select_mecanico;
        private System.Windows.Forms.ComboBox select_operador;
        private System.Windows.Forms.NumericUpDown tiempo_parada;
        private System.Windows.Forms.NumericUpDown tiempo_reparacion;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox text_descripcion;
        private System.Windows.Forms.TextBox text_causa;
        private System.Windows.Forms.Button b_subir;
        private System.Windows.Forms.TextBox text_solucion;
        private System.Windows.Forms.Label l_operador;
        private System.Windows.Forms.Label l_mecanico;
        private System.Windows.Forms.Label l_causa;
        private System.Windows.Forms.Label l_solucion;
        private System.Windows.Forms.Label l_reparacion;
        private System.Windows.Forms.Label l_parada;
        private System.Windows.Forms.Label l_descripcion;
        private System.Windows.Forms.Label l_fecha;
        private System.Windows.Forms.Label l_maquina;
    }
}