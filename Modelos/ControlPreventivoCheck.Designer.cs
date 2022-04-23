namespace ProyectoBD.Modelos
{
    partial class ControlPreventivoCheck
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.dtpPosponer = new System.Windows.Forms.DateTimePicker();
            this.panelReagendar = new System.Windows.Forms.Panel();
            this.btnReajendar = new System.Windows.Forms.Button();
            this.lblPostSemana = new System.Windows.Forms.Label();
            this.cbReagendar = new System.Windows.Forms.CheckBox();
            this.numReparacion = new System.Windows.Forms.NumericUpDown();
            this.numParada = new System.Windows.Forms.NumericUpDown();
            this.lblTR = new System.Windows.Forms.Label();
            this.lblTP = new System.Windows.Forms.Label();
            this.lblMecanico = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.listaMecanicos = new System.Windows.Forms.ComboBox();
            this.panelReagendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(14, 9);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(14, 13);
            this.lblPlan.TabIndex = 0;
            this.lblPlan.Text = "A";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(34, 10);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(72, 13);
            this.lblMaquina.TabIndex = 1;
            this.lblMaquina.Text = "<<Maquina>>";
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Location = new System.Drawing.Point(136, 9);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(87, 13);
            this.lblSemana.TabIndex = 2;
            this.lblSemana.Text = "Semana <<No>>";
            // 
            // dtpPosponer
            // 
            this.dtpPosponer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPosponer.Location = new System.Drawing.Point(96, 3);
            this.dtpPosponer.MinDate = new System.DateTime(2022, 4, 16, 11, 57, 31, 591);
            this.dtpPosponer.Name = "dtpPosponer";
            this.dtpPosponer.Size = new System.Drawing.Size(19, 20);
            this.dtpPosponer.TabIndex = 3;
            this.dtpPosponer.Value = new System.DateTime(2022, 4, 16, 11, 57, 31, 591);
            this.dtpPosponer.ValueChanged += new System.EventHandler(this.dtpPosponer_ValueChanged);
            // 
            // panelReagendar
            // 
            this.panelReagendar.Controls.Add(this.btnReajendar);
            this.panelReagendar.Controls.Add(this.lblPostSemana);
            this.panelReagendar.Controls.Add(this.dtpPosponer);
            this.panelReagendar.Location = new System.Drawing.Point(247, 3);
            this.panelReagendar.Name = "panelReagendar";
            this.panelReagendar.Size = new System.Drawing.Size(161, 28);
            this.panelReagendar.TabIndex = 4;
            this.panelReagendar.Visible = false;
            // 
            // btnReajendar
            // 
            this.btnReajendar.Location = new System.Drawing.Point(121, 2);
            this.btnReajendar.Name = "btnReajendar";
            this.btnReajendar.Size = new System.Drawing.Size(37, 23);
            this.btnReajendar.TabIndex = 6;
            this.btnReajendar.Text = "OK";
            this.btnReajendar.UseVisualStyleBackColor = true;
            this.btnReajendar.Click += new System.EventHandler(this.btnReajendar_Click);
            // 
            // lblPostSemana
            // 
            this.lblPostSemana.AutoSize = true;
            this.lblPostSemana.Location = new System.Drawing.Point(3, 7);
            this.lblPostSemana.Name = "lblPostSemana";
            this.lblPostSemana.Size = new System.Drawing.Size(87, 13);
            this.lblPostSemana.TabIndex = 5;
            this.lblPostSemana.Text = "Semana <<No>>";
            // 
            // cbReagendar
            // 
            this.cbReagendar.AutoSize = true;
            this.cbReagendar.Location = new System.Drawing.Point(229, 8);
            this.cbReagendar.Name = "cbReagendar";
            this.cbReagendar.Size = new System.Drawing.Size(79, 17);
            this.cbReagendar.TabIndex = 5;
            this.cbReagendar.Text = "Reagendar";
            this.cbReagendar.UseVisualStyleBackColor = true;
            this.cbReagendar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numReparacion
            // 
            this.numReparacion.DecimalPlaces = 2;
            this.numReparacion.Location = new System.Drawing.Point(6, 60);
            this.numReparacion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numReparacion.Name = "numReparacion";
            this.numReparacion.Size = new System.Drawing.Size(127, 20);
            this.numReparacion.TabIndex = 6;
            // 
            // numParada
            // 
            this.numParada.DecimalPlaces = 2;
            this.numParada.Location = new System.Drawing.Point(139, 60);
            this.numParada.Name = "numParada";
            this.numParada.Size = new System.Drawing.Size(102, 20);
            this.numParada.TabIndex = 7;
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.Location = new System.Drawing.Point(17, 44);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(100, 13);
            this.lblTR.TabIndex = 9;
            this.lblTR.Text = "Tiempo Reparacion";
            // 
            // lblTP
            // 
            this.lblTP.AutoSize = true;
            this.lblTP.Location = new System.Drawing.Point(141, 44);
            this.lblTP.Name = "lblTP";
            this.lblTP.Size = new System.Drawing.Size(79, 13);
            this.lblTP.TabIndex = 10;
            this.lblTP.Text = "Tiempo Parada";
            // 
            // lblMecanico
            // 
            this.lblMecanico.AutoSize = true;
            this.lblMecanico.Location = new System.Drawing.Point(289, 44);
            this.lblMecanico.Name = "lblMecanico";
            this.lblMecanico.Size = new System.Drawing.Size(54, 13);
            this.lblMecanico.TabIndex = 11;
            this.lblMecanico.Text = "Mecanico";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(3, 86);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(402, 59);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // listaMecanicos
            // 
            this.listaMecanicos.FormattingEnabled = true;
            this.listaMecanicos.Location = new System.Drawing.Point(253, 60);
            this.listaMecanicos.Name = "listaMecanicos";
            this.listaMecanicos.Size = new System.Drawing.Size(152, 21);
            this.listaMecanicos.TabIndex = 14;
            // 
            // ControlPreventivoCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listaMecanicos);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblMecanico);
            this.Controls.Add(this.lblTP);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.numParada);
            this.Controls.Add(this.numReparacion);
            this.Controls.Add(this.panelReagendar);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.cbReagendar);
            this.Name = "ControlPreventivoCheck";
            this.Size = new System.Drawing.Size(415, 150);
            this.panelReagendar.ResumeLayout(false);
            this.panelReagendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.DateTimePicker dtpPosponer;
        private System.Windows.Forms.Panel panelReagendar;
        private System.Windows.Forms.Button btnReajendar;
        private System.Windows.Forms.Label lblPostSemana;
        private System.Windows.Forms.CheckBox cbReagendar;
        private System.Windows.Forms.NumericUpDown numReparacion;
        private System.Windows.Forms.NumericUpDown numParada;
        private System.Windows.Forms.Label lblTR;
        private System.Windows.Forms.Label lblTP;
        private System.Windows.Forms.Label lblMecanico;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox listaMecanicos;
    }
}
