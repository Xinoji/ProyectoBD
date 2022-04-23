    namespace ProyectoBD.Modelos
{
    partial class ControlDatosPreventivos
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
            this.lblMecanico = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCorrectivo = new System.Windows.Forms.Label();
            this.lblParada = new System.Windows.Forms.Label();
            this.lblReparacion = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mecanico = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMecanico
            // 
            this.lblMecanico.AutoSize = true;
            this.lblMecanico.Location = new System.Drawing.Point(105, 0);
            this.lblMecanico.Name = "lblMecanico";
            this.lblMecanico.Size = new System.Drawing.Size(54, 13);
            this.lblMecanico.TabIndex = 10;
            this.lblMecanico.Text = "Mecanico";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(135, 1);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Padding = new System.Windows.Forms.Padding(16);
            this.lblFecha.Size = new System.Drawing.Size(69, 45);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";

            // 
            // lblCorrectivo
            // 
            this.lblCorrectivo.AutoSize = true;
            this.lblCorrectivo.Location = new System.Drawing.Point(4, 1);
            this.lblCorrectivo.Name = "lblCorrectivo";
            this.lblCorrectivo.Padding = new System.Windows.Forms.Padding(16);
            this.lblCorrectivo.Size = new System.Drawing.Size(108, 45);
            this.lblCorrectivo.TabIndex = 0;
            this.lblCorrectivo.Text = "PREVENTIVO";
            // 
            // lblParada
            // 
            this.lblParada.AutoSize = true;
            this.lblParada.Location = new System.Drawing.Point(528, 1);
            this.lblParada.Name = "lblParada";
            this.lblParada.Padding = new System.Windows.Forms.Padding(16);
            this.lblParada.Size = new System.Drawing.Size(74, 45);
            this.lblParada.TabIndex = 12;
            this.lblParada.Text = "Tiempo";
            // 
            // lblReparacion
            // 
            this.lblReparacion.AutoSize = true;
            this.lblReparacion.Location = new System.Drawing.Point(659, 1);
            this.lblReparacion.Name = "lblReparacion";
            this.lblReparacion.Padding = new System.Windows.Forms.Padding(16);
            this.lblReparacion.Size = new System.Drawing.Size(74, 45);
            this.lblReparacion.TabIndex = 11;
            this.lblReparacion.Text = "Tiempo";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(266, 1);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Padding = new System.Windows.Forms.Padding(16);
            this.lblMaquina.Size = new System.Drawing.Size(80, 45);
            this.lblMaquina.TabIndex = 9;
            this.lblMaquina.Text = "Maquina";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(397, 1);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Padding = new System.Windows.Forms.Padding(16);
            this.lblPlan.Size = new System.Drawing.Size(60, 45);
            this.lblPlan.TabIndex = 14;
            this.lblPlan.Text = "Plan";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaquina, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCorrectivo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPlan, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblParada, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblReparacion, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.mecanico, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 50);
            this.tableLayoutPanel1.TabIndex = 15;

            // 
            // mecanico
            // 
            this.mecanico.AutoSize = true;
            this.mecanico.Location = new System.Drawing.Point(790, 1);
            this.mecanico.Name = "mecanico";
            this.mecanico.Padding = new System.Windows.Forms.Padding(16);
            this.mecanico.Size = new System.Drawing.Size(86, 45);
            this.mecanico.TabIndex = 15;
            this.mecanico.Text = "Mecanico";
            // 
            // ControlDatosPreventivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ControlDatosPreventivos";
            this.Size = new System.Drawing.Size(1050, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMecanico;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCorrectivo;
        private System.Windows.Forms.Label lblParada;
        private System.Windows.Forms.Label lblReparacion;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label mecanico;
    }
}
