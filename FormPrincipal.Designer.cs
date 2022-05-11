namespace ProyectoBD
{
    partial class FormPrincipal
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
            this.panelNavegacion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.btnAltas = new System.Windows.Forms.Button();
            this.btnReparacion = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnPanel = new System.Windows.Forms.Button();
            this.panelNavegacion.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.AutoScroll = true;
            this.panelNavegacion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelNavegacion.Controls.Add(this.label1);
            this.panelNavegacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavegacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelNavegacion.Location = new System.Drawing.Point(0, 0);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(299, 120);
            this.panelNavegacion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lito";
            // 
            // panelContenido
            // 
            this.panelContenido.AutoSize = true;
            this.panelContenido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContenido.Controls.Add(this.btnAltas);
            this.panelContenido.Controls.Add(this.btnReparacion);
            this.panelContenido.Controls.Add(this.btnInventario);
            this.panelContenido.Controls.Add(this.btnPanel);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 120);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(299, 320);
            this.panelContenido.TabIndex = 2;
            // 
            // btnAltas
            // 
            this.btnAltas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltas.Location = new System.Drawing.Point(0, 147);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(299, 49);
            this.btnAltas.TabIndex = 3;
            this.btnAltas.Text = "Altas y Bajas";
            this.btnAltas.UseVisualStyleBackColor = true;
            this.btnAltas.Click += new System.EventHandler(this.btnAltas_Click);
            // 
            // btnReparacion
            // 
            this.btnReparacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReparacion.Location = new System.Drawing.Point(0, 98);
            this.btnReparacion.Name = "btnReparacion";
            this.btnReparacion.Size = new System.Drawing.Size(299, 49);
            this.btnReparacion.TabIndex = 2;
            this.btnReparacion.Text = "Reportes y Reparaciones";
            this.btnReparacion.UseVisualStyleBackColor = true;
            this.btnReparacion.Click += new System.EventHandler(this.btnReparacion_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Location = new System.Drawing.Point(0, 49);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(299, 49);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnPanel
            // 
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanel.Location = new System.Drawing.Point(0, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(299, 49);
            this.btnPanel.TabIndex = 0;
            this.btnPanel.Text = "Panel de Control";
            this.btnPanel.UseVisualStyleBackColor = true;
            this.btnPanel.Click += new System.EventHandler(this.btnPanel_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 440);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelNavegacion);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.panelNavegacion.ResumeLayout(false);
            this.panelNavegacion.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltas;
        private System.Windows.Forms.Button btnReparacion;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnPanel;
    }
}