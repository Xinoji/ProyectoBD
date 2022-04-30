namespace ProyectoBD.Modelos
{
    partial class FormRePreventivo
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
            this.components = new System.ComponentModel.Container();
            this.lector_semana = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_reagendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lector_semana
            // 
            this.lector_semana.Location = new System.Drawing.Point(154, 9);
            this.lector_semana.Name = "lector_semana";
            this.lector_semana.Size = new System.Drawing.Size(158, 20);
            this.lector_semana.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(47, 52);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(82, 24);
            this.b_cancel.TabIndex = 2;
            this.b_cancel.Text = "Cancelar";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // b_reagendar
            // 
            this.b_reagendar.Location = new System.Drawing.Point(210, 52);
            this.b_reagendar.Name = "b_reagendar";
            this.b_reagendar.Size = new System.Drawing.Size(83, 24);
            this.b_reagendar.TabIndex = 3;
            this.b_reagendar.Text = "Reagendar";
            this.b_reagendar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reagendar a semana:";
            // 
            // FormRePreventivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 88);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_reagendar);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.lector_semana);
            this.Name = "FormRePreventivo";
            this.Text = "Reagendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lector_semana;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_reagendar;
        private System.Windows.Forms.Label label1;
    }
}