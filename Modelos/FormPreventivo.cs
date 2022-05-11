using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoBD.Logica;


namespace ProyectoBD.Modelos
{
    public partial class FormPreventivo : Form
    {
        private List<string> maquinas = new List<string>();
        private bool is_selected = false;

        private List<element_plan> in_query = new List<element_plan>();
        private List<element_plan> current_query = new List<element_plan>();
        private List<reagendar_element> list_reagendar = new List<reagendar_element>();

        private HScrollBar scrollbar;

        private int current_scroll = 0;
        private int show_week = 23;
        private int n_week;

        private Bitmap bitmap_grid;

        private Color[] grid_colores = new Color[4];

        //Grid Exterior
        private Label[] l_semanas;
        private Panel panel_grid_exterior;
        //PANEL SEMANA
        private Color c_label_s;
        //PANEL LATERAL PLANES
        private Color c_label_p;
        private Color c_label_p2;
        private Pen arrow_p;
        private Pen arrow_p2;
        //FONDO DE LA GRID
        private Color grid_clean;
        //COLOR DE FONT DE PANEL SEMANA
        private Color c_font_s;
        //COLOR SELECT BACKGROUND
        private Color c_select_b;
        //COLOR SELECT FOREGROUND
        private Color c_select_f;

        private Color wintheme;
        private Color invtheme;

        private int scroll_height = 20;


        private int width_header = 80;
        private int height_header = 20;

        Preventivo preventivo = new Preventivo();

        private Pen grid_pen = new Pen(Color.Black,1.5f);

        public FormPreventivo()
        {
            InitializeComponent();

            bitmap_grid = new Bitmap(show_week, 4);
            setTheme();

            //Lista de maquinas
            preventivo.leer_maquinas(ref maquinas);

            maquina_select.AutoCompleteSource = AutoCompleteSource.ListItems;
            maquina_select.AutoCompleteMode = AutoCompleteMode.Suggest;
            maquina_select.DataSource = maquinas;
            maquina_select.SelectedIndex = -1;

            maquina_select.SelectionChangeCommitted += new EventHandler(maquina_selecionada);
            b_mandar.Click += new EventHandler(mandar_cambios_sql);

            //Grid Configuracion
            configurar_grid();
            year_select.Minimum = 2000;
            year_select.Maximum = 4000;
            year_select.Value = DateTime.Today.Year;
            preventivo.calcular_semanas_especiales(DateTime.Today.Year);

            panel_grid.Paint += new PaintEventHandler(draw_grid);
        }

        private List<element_plan> get_copy_list(List<element_plan> a) {
            List<element_plan> tmp = new List<element_plan>();

            foreach (element_plan ep in a) {
                tmp.Add(new element_plan(ep));
            }

            return tmp;
        }

        private void maquina_selecionada(object sender, EventArgs e)
        {
            //Obtener la maquina
            string select_maquina = (sender as ComboBox).SelectedItem as string;
            //Obtener el year
            int year = (int)year_select.Value;
            preventivo.calcular_semanas_especiales(year);
            n_week = preventivo.max_semana;
            //Obtener el numero de semanas
            scrollbar.Minimum = 0;
            scrollbar.Maximum = n_week - show_week;

            limpiar_grid();
            list_reagendar.Clear();
            in_query.Clear();
            current_query.Clear();

            preventivo.leer_preventivos(ref in_query, year, select_maquina);

            current_query = get_copy_list(in_query);

            procesar_lista_grid(current_scroll);

            is_selected = true;

        }

        private void configurar_grid()
        {
            create_labels(2, 2);
            grid_column_enumerate(0);
            //Agregar ScrollBar
            scrollbar = new HScrollBar();

            scrollbar.Size = new Size(panel_grid.Width, scroll_height);
            scrollbar.Location = new Point(width_header,panel_grid.Height + height_header);
            scrollbar.LargeChange = 1;
            scrollbar.Minimum = 0;
            scrollbar.Maximum = 10;

            panel_grid_exterior.Controls.Add(scrollbar);

            scrollbar.Scroll += new ScrollEventHandler(scroll_fake);
        }

        private void mandar_cambios_sql(object sender, EventArgs e) {
            if (is_selected)
            {
                //Eliminar datos
                foreach (element_plan iep in in_query)
                {
                    bool esta_en = false;
                    foreach (element_plan ep in current_query)
                    {
                        if (iep.folio == ep.folio) {
                            esta_en = true;
                            break;
                        }
                    }

                    if (!esta_en) {
                        Console.WriteLine("Folio eliminado: {0}", iep.folio);
                        preventivo.query_eliminar(iep.folio);
                    }
                }
                //Agregar datos y reagendar
                foreach (element_plan ep in current_query)
                {
                    bool esta_en = false;
                    foreach (element_plan iep in in_query)
                    {

                        if (ep == iep) {
                            esta_en = true;
                            break;
                        }

                    }

                    if (!esta_en) {
                        if (ep.update_from == -1)
                        {
                            //AGREGAR
                            int folio = preventivo.query_agregar(maquina_select.SelectedItem as string, ep.semana, ep.plan);
                            Console.WriteLine("Regristro agregado: {0}", folio);
                            ep.folio = folio;
                        }else {
                            //REAGENDAR
                            int result = preventivo.query_reagendar(ep);

                            if (result == 0)
                            {
                                Console.WriteLine("No se reagendaron xD");
                            }
                            else {
                                Console.WriteLine("Se reagendo: {0}", ep.folio);
                            }
                        }

                    }
                }

                in_query = get_copy_list(current_query);
                MessageBox.Show("Modificaciones guardadas");
            }
            else {
                MessageBox.Show("Seleccione una maquina,para modificar");
            }
        }
        private void grid_column_enumerate(int offset) {
            int i = 1 + offset;

            foreach (Label label in l_semanas)
            {
                label.Text = i.ToString();
                label.Refresh();
                i++;
            }   
        }

        private void scroll_fake(object sender, ScrollEventArgs e) {
            procesar_lista_grid(scrollbar.Value);

            current_scroll = scrollbar.Value;

            grid_column_enumerate(current_scroll);
        }

        /*
            DE AQUI PARA ABAJO SON PARA LA GRID
         */
        public static Color color_blend(Color A, Color B, double mut)
        {
            byte r = (byte)(A.R * mut + B.R * (1 - mut));
            byte g = (byte)(A.G * mut + B.G * (1 - mut));
            byte b = (byte)(A.B * mut + B.B * (1 - mut));
            return Color.FromArgb(255, r, g, b);
        }
        public static Color color_desaturate(Color c,double s) {
            double l = (double)(0.3 * c.R + 0.6 * c.G + 0.1 * c.B);
            byte r = (byte)(c.R + s * (l - c.R));
            byte g = (byte)(c.G + s * (l - c.G));
            byte b = (byte)(c.B + s * (l - c.B));
            return Color.FromArgb(255,r,g,b);
        }
        public static Color color_gray(int value) {
            return Color.FromArgb(255,value,value,value);
        }
        public static bool is_cool_color(Color c) {
            float H = c.GetHue();
            if (H > 90 && H < 270) return true;
            else return false;
        }
        public static bool is_dark_color(Color c){
            return (c.R * 0.2126 + c.G * 0.7152 + c.B * 0.0722) < (255 / 2);
        }
        public static Color color_map(Color c, Color reference, double y, double x) {
            return color_desaturate(color_blend(reference,c,y),x);
        }
        private async Task setTheme()
        {
            wintheme = WinTheme.GetAccentColor();
            invtheme = WinTheme.InvertMeAColour(wintheme);
            var lightColor = ControlPaint.Light(wintheme);
            var darkColor = ControlPaint.Dark(wintheme);
            var lightlight = ControlPaint.LightLight(wintheme);
            var darklightlight = ControlPaint.Dark(lightlight);

            //Si el color es frio
            if (is_cool_color(wintheme))
            {

                //Quitamos saturacion
                BackColor = color_desaturate(darklightlight, 0.2);

                //Quitamos Saturacion
                c_label_s = color_desaturate(invtheme, 0.4);
                if (is_dark_color(c_label_s))
                    c_font_s = Color.White;
                else
                    c_font_s = darkColor;

                c_label_p = color_blend(c_label_s,invtheme, 0.9);
                c_label_p2 = color_map(darklightlight,wintheme,0.3,0.4);

                c_select_b = color_map(BackColor,lightColor,0.2,0.2);

                if (is_dark_color(c_select_b))
                    c_select_f = Color.White;
                else
                    c_select_f = darkColor;

                grid_clean = color_blend(color_gray(250), invtheme, 0.85);
            }
            else {
                //Agregamos Saturacion
                BackColor = color_desaturate(wintheme,0.3);

                //Agregamos Saturacion
                c_label_s = color_desaturate(color_blend(invtheme, darkColor, 0.8),0.4);
                if (is_dark_color(c_label_s))
                    c_font_s = Color.White;
                else
                    c_font_s = darkColor;

                c_label_p = color_blend(ControlPaint.LightLight(c_label_s), darkColor, 0.2);
                c_label_p2 = color_blend(lightColor, wintheme, 0.4);

                c_select_b = ControlPaint.Light(BackColor);

                if (is_dark_color(c_select_b))
                    c_select_f = Color.White;
                else
                    c_select_f = darkColor;

                grid_clean = color_blend(color_gray(250), invtheme, 0.85);
            }


            maquina_select.BackColor = c_select_b;
            maquina_select.ForeColor = c_select_f;
            b_mandar.BackColor = c_select_b;
            b_mandar.ForeColor = c_select_f;
            year_select.BackColor = c_select_b;
            year_select.ForeColor = c_select_f;

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < show_week; j++) {
                    bitmap_grid.SetPixel(j,i,grid_clean);
                }
            }
        }
        private void limpiar_grid_element(element_plan ep){
            int semana_r = ep.semana - current_scroll - 1;
            bitmap_grid.SetPixel(semana_r, ep.plan, grid_clean);
        }

        private void procesar_lista_grid(int new_sc_i) {
            foreach (element_plan ep in current_query) {

                if (ep.plan == -1) continue;

                int pre_semana = ep.semana - 1 - current_scroll;
                int pos_semana = ep.semana - 1 - new_sc_i;
                //Limpiar Celda anterior
                if (pre_semana >= 0 && pre_semana < show_week) {
                    bitmap_grid.SetPixel(pre_semana,ep.plan, grid_clean);
                }


                if (pos_semana >= 0 && pos_semana < show_week) {
                    bitmap_grid.SetPixel(pos_semana, ep.plan, grid_colores[ep.plan]);
                }
                    
            }

            panel_grid.Invalidate();
        }

        private void draw_grid(object sender,PaintEventArgs e) {
            Graphics graph = e.Graphics;
            Panel pl = (Panel)sender;

            graph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            graph.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

            graph.Clear(grid_clean);

            graph.DrawImage(bitmap_grid,0,0,pl.Width,pl.Height);

            float witdh = (float)pl.Width/show_week;
            float height = (float)pl.Height / 4;

            //MOSTRAR MALLA
            for (int x = 1; x <= show_week; x++) {
                graph.DrawLine(grid_pen,x*witdh, 0,x*witdh, pl.Height);
            }

            for (int y = 0; y < 4; y++) {
                graph.DrawLine(grid_pen,0,y*height,pl.Width,y*height);
            }

            //PINTAR FLECHAS
            foreach (reagendar_element re in list_reagendar) {
                Pen tmp_pen;
                if (re.plan % 2 == 1) tmp_pen = arrow_p;
                else tmp_pen = arrow_p2;


                int from_tmp = re.from - current_scroll;
                int to_tmp = re.to - current_scroll;

                float from_offset = 0.0f;
                if (re.from < re.to)
                {
                    to_tmp--;
                    from_offset = -(witdh / 2f);
                }
                else {
                    from_tmp--;
                    from_offset = witdh / 2f;
                }

                int arrow_height = (re.plan * (int)height) + (int)(height/2f);

                graph.DrawLine(tmp_pen, to_tmp * witdh, arrow_height, (from_tmp * witdh) + from_offset, arrow_height);
            }

            
        }

        private void limpiar_grid() {
            foreach (element_plan ep in current_query)
            {
                if (ep.plan == -1) continue;

                int pre_semana = ep.semana - 1 - current_scroll;
                //Limpiar Celda anterior
                if (pre_semana >= 0 && pre_semana < show_week)
                {
                    bitmap_grid.SetPixel(pre_semana, ep.plan, grid_clean);
                }
            }
        }
        private void show_info_week(int semana) {
            string inicio = "";
            string fin = "";

            preventivo.get_limit_week(semana, ref inicio, ref fin);

            MessageBox.Show("          Semana " + semana + "\nInicia: " + inicio + "\nTermina: " + fin);
        }
        private void grid_click(object sender,MouseEventArgs e) {
            Panel panel = (Panel)sender;

            float width_f = (float)panel.Width / show_week;
            float height_f = (float)panel.Height / 4;

            if (panel.Name == "GRID")
            {
                if (!is_selected) {
                    MessageBox.Show("Seleccione una maquina,para modificar");
                    return;
                }
                int click_x = (int)(e.X /width_f);
                int click_y = (int)(e.Y /height_f);

                element_plan tmp = new element_plan(click_x + 1 + current_scroll,click_y, -1);

                int index = tmp.encontrado_en(current_query);

                switch (e.Button) {
                    case MouseButtons.Left: {
                            if (index != -1)
                            {
                                //REAGENDAR
                                element_plan ep = current_query[index];
                                using (FormRePreventivo reagendar = new FormRePreventivo(n_week, MousePosition.X, MousePosition.Y
                                                                                        , c_select_b, c_select_f, c_label_s, c_font_s))
                                {
                                    DialogResult result = reagendar.ShowDialog();
                                    if (result == DialogResult.OK)
                                    {
                                        Console.WriteLine("Reagendar a {0}", reagendar.semana_registrada);
                                        limpiar_grid_element(ep);
                                        if (ep.folio != -1)
                                            ep.insert_update(reagendar.semana_registrada);
                                        else
                                            ep.semana = reagendar.semana_registrada;

                                        ep.autoinsert_in(ref list_reagendar);
                                        if (ep.semana == ep.update_from)
                                            ep.autoquit_in(ref list_reagendar);
                                    }
                                }
                            }else {
                                //AGREGAR
                                current_query.Add(tmp);
                            }

                            break;
                        }
                    case MouseButtons.Right: {
                            if (index != -1) {
                                current_query[index].autoquit_in(ref list_reagendar);
                                current_query.RemoveAt(index);
                                limpiar_grid_element(tmp);
                            }
                            break;
                        }
                }
            }else if(e.X > width_header && e.Y < height_header){
                show_info_week((e.X - width_header)/(int)width_f + 1);
            }

            procesar_lista_grid(current_scroll);
        }
        private void click_week(object sender,MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Label label = (Label)sender;
                show_info_week(Int32.Parse(label.Text));
            }
        }
        private void create_labels(int offset_x,int offset_y) {

            l_semanas = new Label[show_week];

            int x_panel = panel_grid.Left;
            int y_panel = panel_grid.Top;


            float witdh_f = (float)panel_grid.Width / show_week;
            float height_f = (float)panel_grid.Height / 4;

            panel_grid_exterior = new Panel();
            panel_grid_exterior.Location = new Point(x_panel - width_header, y_panel - height_header);
            panel_grid_exterior.Size = new Size(panel_grid.Width + width_header, panel_grid.Height + height_header + scroll_height);
            panel_grid_exterior.Paint += new PaintEventHandler(paint_panel);
            panel_grid_exterior.MouseDoubleClick += new MouseEventHandler(grid_click);
            panel_grid.MouseDoubleClick += new MouseEventHandler(grid_click);
            panel_grid.Name = "GRID";

            for (int i = 0; i < show_week; i++) {
                Label tmp = l_semanas[i] = new Label();

                tmp.Text = (i + 1).ToString();
                tmp.Parent = panel_grid_exterior;
                tmp.BackColor = c_label_s;
                tmp.ForeColor = c_font_s;
                tmp.Font = new Font("Lucida Console",8);
                tmp.Location = new Point(x_panel + (int)(witdh_f * i) + offset_x, y_panel + offset_y - height_header);
                tmp.Size = new Size((int)witdh_f - 4,height_header);
                tmp.MouseDoubleClick += new MouseEventHandler(click_week);

                Controls.Add(tmp);
            }

            Controls.Add(panel_grid_exterior);
        }

        private void paint_panel(object sender, PaintEventArgs e) {
            Panel panel = (Panel)sender;
            Graphics graph = e.Graphics;
            graph.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;

            float height_f = (float)panel_grid.Height / 4;

            Font tmp_font = new Font("Lucida Console", 8);

            int font_x_offset = (int)(width_header / 4f);
            int font_y_offset = (int)(height_f / 4f);

            

            using (SolidBrush brush = new SolidBrush(c_label_p2)) {
                
                graph.FillRectangle(brush,new Rectangle(0,0,panel.Width,panel.Height));

                brush.Color = c_label_s;
                graph.FillRectangle(brush,new Rectangle(width_header,0,panel.Width - width_header,height_header));
                brush.Color = c_label_p;
                //LABEL_NAME
                graph.FillRectangle(brush, new Rectangle(0, 0,width_header, height_header));

                //PLAN B
                graph.FillRectangle(brush, new Rectangle(0,height_header + (int)(1 * height_f), width_header,(int)height_f));
                //PLAN D
                graph.FillRectangle(brush, new Rectangle(0, height_header + (int)(3 * height_f), width_header, (int)height_f));
                grid_colores[1] = brush.Color;
                grid_colores[3] = brush.Color;


                brush.Color = c_label_p2;
                arrow_p = new Pen(brush, height_f/4f);
                arrow_p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                //PLAN A
                graph.FillRectangle(brush, new Rectangle(0, height_header, width_header, (int)height_f));
                grid_colores[0] = brush.Color;
                grid_colores[2] = brush.Color;
                //PLAN C
                graph.FillRectangle(brush, new Rectangle(0, height_header + (int)(2 * height_f), width_header, (int)height_f));

                //TEXT 
                graph.DrawString("PLAN B", tmp_font, brush, new PointF(0 + font_x_offset, height_header + (int)(1 * height_f) + font_y_offset));
                graph.DrawString("PLAN D", tmp_font, brush, new PointF(0 + font_x_offset, height_header + (int)(3 * height_f) + font_y_offset));
                brush.Color = c_label_p;
                arrow_p2 = new Pen(brush, height_f/4f);
                arrow_p2.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                graph.DrawString("PLAN A", tmp_font, brush, new PointF(0 + font_x_offset, height_header + font_y_offset));
                graph.DrawString("PLAN C", tmp_font, brush, new PointF(0 + font_x_offset, height_header + (int)(2 * height_f) + font_y_offset));

            }
        }
    }
}
