namespace ProyectoBD.Modelos
{
    partial class FormPreventivo
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
            this.maquina_select = new System.Windows.Forms.ComboBox();
            this.b_mandar = new System.Windows.Forms.Button();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.year_select = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.year_select)).BeginInit();
            this.SuspendLayout();
            // 
            // maquina_select
            // 
            this.maquina_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maquina_select.FormattingEnabled = true;
            this.maquina_select.Location = new System.Drawing.Point(304, 16);
            this.maquina_select.Margin = new System.Windows.Forms.Padding(0);
            this.maquina_select.Name = "maquina_select";
            this.maquina_select.Size = new System.Drawing.Size(131, 21);
            this.maquina_select.TabIndex = 2;
            // 
            // b_mandar
            // 
            this.b_mandar.FlatAppearance.BorderSize = 0;
            this.b_mandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_mandar.Location = new System.Drawing.Point(679, 16);
            this.b_mandar.Margin = new System.Windows.Forms.Padding(0);
            this.b_mandar.Name = "b_mandar";
            this.b_mandar.Size = new System.Drawing.Size(65, 21);
            this.b_mandar.TabIndex = 3;
            this.b_mandar.Text = "Modificar";
            this.b_mandar.UseVisualStyleBackColor = true;
            // 
            // panel_grid
            // 
            this.panel_grid.Location = new System.Drawing.Point(80, 78);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Size = new System.Drawing.Size(676, 130);
            this.panel_grid.TabIndex = 5;
            // 
            // year_select
            // 
            this.year_select.Location = new System.Drawing.Point(12, 16);
            this.year_select.Name = "year_select";
            this.year_select.Size = new System.Drawing.Size(120, 20);
            this.year_select.TabIndex = 6;
            // 
            // FormTPreventivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 229);
            this.Controls.Add(this.year_select);
            this.Controls.Add(this.panel_grid);
            this.Controls.Add(this.b_mandar);
            this.Controls.Add(this.maquina_select);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTPreventivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.year_select)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox maquina_select;
        private System.Windows.Forms.Button b_mandar;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.NumericUpDown year_select;
    }
}