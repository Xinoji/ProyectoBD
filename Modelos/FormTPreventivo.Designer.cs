namespace ProyectoBD.Modelos
{
    partial class FormTPreventivo
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
            this.year_select = new System.Windows.Forms.DateTimePicker();
            this.plan_select = new System.Windows.Forms.DataGridView();
            this.maquina_select = new System.Windows.Forms.ComboBox();
            this.b_mandar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plan_select)).BeginInit();
            this.SuspendLayout();
            // 
            // year_select
            // 
            this.year_select.CustomFormat = "yyyy";
            this.year_select.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.year_select.Location = new System.Drawing.Point(12, 12);
            this.year_select.Name = "year_select";
            this.year_select.ShowUpDown = true;
            this.year_select.Size = new System.Drawing.Size(131, 20);
            this.year_select.TabIndex = 0;
            // 
            // plan_select
            // 
            this.plan_select.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plan_select.Location = new System.Drawing.Point(12, 38);
            this.plan_select.Name = "plan_select";
            this.plan_select.Size = new System.Drawing.Size(776, 352);
            this.plan_select.TabIndex = 1;
            // 
            // maquina_select
            // 
            this.maquina_select.FormattingEnabled = true;
            this.maquina_select.Location = new System.Drawing.Point(366, 12);
            this.maquina_select.Name = "maquina_select";
            this.maquina_select.Size = new System.Drawing.Size(131, 21);
            this.maquina_select.TabIndex = 2;
            // 
            // b_mandar
            // 
            this.b_mandar.Location = new System.Drawing.Point(333, 396);
            this.b_mandar.Name = "b_mandar";
            this.b_mandar.Size = new System.Drawing.Size(115, 25);
            this.b_mandar.TabIndex = 3;
            this.b_mandar.Text = "Guadar cambios";
            this.b_mandar.UseVisualStyleBackColor = true;
            // 
            // FormTPreventivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_mandar);
            this.Controls.Add(this.maquina_select);
            this.Controls.Add(this.plan_select);
            this.Controls.Add(this.year_select);
            this.Name = "FormTPreventivo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.plan_select)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker year_select;
        private System.Windows.Forms.DataGridView plan_select;
        private System.Windows.Forms.ComboBox maquina_select;
        private System.Windows.Forms.Button b_mandar;
    }
}