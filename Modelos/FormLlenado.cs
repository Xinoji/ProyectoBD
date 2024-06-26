﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoBD.Logica;
using System.Globalization;

namespace ProyectoBD.Modelos
{
    public partial class FormLlenado : Form
    {
        private Reporte reporte;
        private Llenado llenado = new Llenado();
        private bool is_new;
        private List<string> list_maquinas;
        private List<string> list_operador;
        private List<string> list_mecanico;

        private List<update_element> list_reparacion = new List<update_element>();
        private List<update_element> list_reporte = new List<update_element>();

        private void init_llenado() {
            setTheme();
            list_maquinas = llenado.get_list_query("Modelo", "maquinas");
            list_operador = llenado.get_list_query("nombre", "operador");
            list_mecanico = llenado.get_list_query("nombre", "Mecanico");

            select_maquina.Name = "Modelo_Maquina";
            select_maquina.AutoCompleteSource = AutoCompleteSource.ListItems;
            select_maquina.AutoCompleteMode = AutoCompleteMode.Suggest;
            select_maquina.DataSource = list_maquinas;
            select_maquina.SelectedIndex = -1;

            select_operador.Name = "Operador";
            select_operador.AutoCompleteSource = AutoCompleteSource.ListItems;
            select_operador.AutoCompleteMode = AutoCompleteMode.Suggest;
            select_operador.DataSource = list_operador;
            select_operador.SelectedIndex = -1;

            select_mecanico.Name = "nom_Mecanico";
            select_mecanico.AutoCompleteSource = AutoCompleteSource.ListItems;
            select_mecanico.AutoCompleteMode = AutoCompleteMode.Suggest;
            select_mecanico.DataSource = list_mecanico;
            select_mecanico.SelectedIndex = -1;

            text_descripcion.Name = "Descripcion";
            text_causa.Name = "Causa";
            text_solucion.Name = "Solucion";

            fecha.Name = "Fecha";
        }
        private void init_llenado_update() {
            init_llenado();

            select_maquina.SelectedIndex = select_maquina.FindString(reporte.maquina);
            select_operador.SelectedIndex = select_operador.FindString(reporte.operador);
            select_mecanico.SelectedIndex = select_mecanico.FindString(reporte.mecanico);

            text_descripcion.Text = reporte.descripcion;
            text_causa.Text = reporte.causa;
            text_solucion.Text = reporte.solucion;

            tiempo_parada.Value = reporte.parada;
            tiempo_reparacion.Value = reporte.reparacion;

            fecha.Value = reporte.fecha;
        }

        private async Task setTheme()
        {
            
            var wintheme = WinTheme.GetAccentColor();
            var invtheme = WinTheme.InvertMeAColour(wintheme);
            var lightColor = ControlPaint.Light(wintheme);
            var darkColor = ControlPaint.Dark(wintheme);
            var lightlight = ControlPaint.LightLight(wintheme);
            var lightdarkdarkColor = ControlPaint.Light(ControlPaint.Dark(darkColor));
            var darklightlight = ControlPaint.Dark(lightlight);
            var lightlightInvert = ControlPaint.LightLight(ControlPaint.Dark(WinTheme.InvertMeAColour(wintheme)));

            Color back = Color.White;
            Color fore = Color.White;
            Color select_back = Color.White;
            Color select_fore = Color.White;
            Color b_back = Color.White;
            Color b_fore = Color.White;

            if (FormPreventivo.is_cool_color(wintheme))
            {
                back = ControlPaint.Dark(wintheme, 0.2f);
            }
            else {
                back = FormPreventivo.color_desaturate(wintheme,0.2);
            }

            b_back = WinTheme.InvertMeAColour(lightlight);

            select_back = ControlPaint.Light(back, 0.1f);

            if (FormPreventivo.is_dark_color(select_back))
                select_fore = Color.White;
            else select_fore = darkColor;

            if (FormPreventivo.is_dark_color(b_back))
                b_fore = Color.White;
            else b_fore = darkColor;

            BackColor = back;
            ForeColor = select_fore;

            l_causa.BackColor = select_back;
            l_descripcion.BackColor = select_back;
            l_fecha.BackColor = select_back;
            l_maquina.BackColor = select_back;
            l_mecanico.BackColor = select_back;
            l_operador.BackColor = select_back;
            l_parada.BackColor = select_back;
            l_reparacion.BackColor = select_back;
            l_solucion.BackColor = select_back;

            text_causa.BackColor = select_back;
            text_causa.ForeColor = select_fore;
            text_descripcion.BackColor = select_back;
            text_descripcion.ForeColor = select_fore;
            text_solucion.BackColor = select_back;
            text_solucion.ForeColor = select_fore;
            select_maquina.BackColor = select_back;
            select_maquina.ForeColor = select_fore;
            select_mecanico.BackColor = select_back;
            select_mecanico.ForeColor = select_fore;
            select_operador.BackColor = select_back;
            select_operador.ForeColor = select_fore;

            tiempo_parada.BackColor = select_back;
            tiempo_parada.ForeColor = select_fore;
            tiempo_reparacion.BackColor = select_back;
            tiempo_reparacion.ForeColor = select_fore;

            b_subir.BackColor = b_back;
            b_subir.ForeColor = b_fore;
        }
        private void insert_update_element(ref update_element element, ref List<update_element> lista) {
            bool encontrado = false;
            foreach (update_element ue in lista)
            {
                if (ue == element)
                {
                    encontrado = true;
                    ue.value = element.value;
                    break;
                }
            }

            if (!encontrado)
            {
                lista.Add(element);
            }
        }
        private string agregar_comillas(string text) {
            return "'" + text.Replace(@"'", "") + "'";
        }
        private void cb_update(object sender, EventArgs e, ref List<update_element> lista) {
            ComboBox cb = (ComboBox)sender;

            update_element tmp = new update_element(cb.Name,agregar_comillas(cb.SelectedItem as string));

            insert_update_element(ref tmp,ref lista);
        }
        private void tb_update(object sender, EventArgs e, ref List<update_element> lista) {
            TextBox tb = (TextBox)sender;

            update_element tmp = new update_element(tb.Name, agregar_comillas(tb.Text));

            insert_update_element(ref tmp, ref lista);
        }
        private void nud_update_on_reparacion(object sender, EventArgs e) {
            NumericUpDown nud = (NumericUpDown)sender;

            update_element tmp = new update_element(nud.Name,nud.Value.ToString(CultureInfo.InvariantCulture));

            insert_update_element(ref tmp,ref list_reparacion);
        }

        private void date_update_on_reparacion(object sender, EventArgs e) {
            DateTimePicker date = (DateTimePicker)sender;

            update_element tmp = new update_element(date.Name, agregar_comillas(date.Value.ToString("yyyy-MM-dd")));

            insert_update_element(ref tmp, ref list_reparacion);
        }

        private void cb_update_on_reparacion(object sender,EventArgs e) {
            cb_update(sender, e, ref list_reparacion);
        }

        private void cb_update_on_reporte(object sender, EventArgs e) {
            cb_update(sender,e,ref list_reporte);
        }

        private void tb_update_on_reparacion(object sender, EventArgs e) {
            tb_update(sender,e,ref list_reparacion);
        }

        private void tb_update_on_reporte(object sender, EventArgs e) {
            tb_update(sender,e,ref list_reporte);
        }

        private void init_event() {
            //LISTAS
            select_maquina.SelectionChangeCommitted += new EventHandler(cb_update_on_reparacion);
            select_mecanico.SelectionChangeCommitted += new EventHandler(cb_update_on_reparacion);
            select_operador.SelectionChangeCommitted += new EventHandler(cb_update_on_reporte);

            //TEXT BOX
            text_descripcion.TextChanged += new EventHandler(tb_update_on_reparacion);
            text_causa.TextChanged += new EventHandler(tb_update_on_reporte);
            text_solucion.TextChanged += new EventHandler(tb_update_on_reporte);

            //NUMERICUPDOWN
            tiempo_parada.ValueChanged += new EventHandler(nud_update_on_reparacion);
            tiempo_reparacion.ValueChanged += new EventHandler(nud_update_on_reparacion);

            //DATE
            fecha.ValueChanged += new EventHandler(date_update_on_reparacion);
        }
        public FormLlenado()
        {
            InitializeComponent();
            b_subir.Click += new System.EventHandler(subir);
            reporte = new Reporte();
            is_new = true;
            b_subir.Text = "Crear reporte";

            init_llenado();
            init_event();

            fecha.Value = DateTime.Now;
        }
        public FormLlenado(int Folio)
        {
            InitializeComponent();
            b_subir.Click += new System.EventHandler(subir);
            is_new = false;

            b_subir.Text = "Modificar reporte";

            reporte = llenado.get_reporte(Folio);

            if (reporte.folio != -1)
            {
                init_llenado_update();
                init_event();
            }
            else {
                MessageBox.Show("Ups... Ha ocurrido un error");
                this.Close();
            }

            
        }
        private void subir(object sender, EventArgs e)
        {
            if (is_new) {
                //AGREGAR
                int create_folio = llenado.crear_correctivo(ref list_reparacion, ref list_reporte);

                Console.WriteLine("folio: {0}",create_folio);

                if (create_folio != -1)
                {
                    is_new = false;

                    list_reparacion.Clear();
                    list_reporte.Clear();

                    b_subir.Text = "Modificar reporte";
                    reporte.folio = create_folio;
                }
                else {
                    MessageBox.Show("Error al crear el reporte");
                }
            }else{
                //UPDATE
                llenado.update_correctivo(reporte.folio,ref list_reparacion,ref list_reporte);

                list_reparacion.Clear();
                list_reporte.Clear();
            }
        }
    }
}
