using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBD.Modelos;

namespace ProyectoBD
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            setTheme();
        }

        private void setTheme()
        {
            var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);
            var lightlight = ControlPaint.LightLight(themeColor);
            var lightdarkdarkColor = ControlPaint.Light(ControlPaint.Dark(darkColor));
            var darklightlight = ControlPaint.Dark(lightlight);
            var lightlightInvert = ControlPaint.LightLight(ControlPaint.Dark(WinTheme.InvertMeAColour(themeColor)));
            
            panelNavegacion.BackColor = themeColor;
            panelNavegacion.ForeColor = lightColor;

            btnAltas.BackColor = lightColor;
            btnAltas.ForeColor = Color.White;
            btnAltas.FlatAppearance.BorderColor = themeColor;
            btnAltas.FlatAppearance.MouseOverBackColor = lightlight;
            
            btnInventario.BackColor = lightColor;
            btnInventario.ForeColor = Color.White;
            btnInventario.FlatAppearance.BorderColor = themeColor;
            btnInventario.FlatAppearance.MouseOverBackColor = lightlight;

            btnPanel.BackColor = lightColor;
            btnPanel.ForeColor = Color.White;
            btnPanel.FlatAppearance.BorderColor = themeColor;
            btnPanel.FlatAppearance.MouseOverBackColor = lightlight;

            btnReparacion.BackColor = lightColor;
            btnReparacion.ForeColor = Color.White;
            btnReparacion.FlatAppearance.BorderColor = themeColor;
            btnReparacion.FlatAppearance.MouseOverBackColor = lightlight;
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            new FormDashboard().Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            new FormInventario().Show();   
        }

        private void btnReparacion_Click(object sender, EventArgs e)
        {
            new FormConcentrado().Show();
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            new FormIngresa().Show();
        }
    }
}
