using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoBD.BD;
using System.Data.SqlClient;
using System.Globalization;

namespace ProyectoBD.Modelos
{
    public partial class FormTPreventivo : Form
    {
        public class SimpleConnection : DbConnection {
            public SqlConnection get_connection() { return GetConnection(); }
        };

        class element_plan { 
            public int semana { get; set; } 
            public int plan { get; set; }
            public int folio { get; set; } 
            public int update_to { get; set; }
            public element_plan(int s, int p, int f) { semana = s; plan = p; folio = f; update_to = -1; }

            public element_plan(element_plan ep) {
                semana = ep.semana;
                plan = ep.plan;
                folio = ep.folio;
                update_to = ep.update_to;
            }
            public void insert_update(int u) {
                int aux = semana;
                semana = u;
                update_to = aux;
            }

            public static bool operator ==(element_plan a, element_plan b) {
                return a.semana == b.semana && a.plan == b.plan;
            }
            public static bool operator !=(element_plan a, element_plan b)
            {
                return a.semana != b.semana || a.plan != b.plan;
            }
        };

        private List<string> maquinas = new List<string>();
        private bool is_selected = false;

        private List<element_plan> in_query = new List<element_plan>();
        private List<element_plan> current_query = new List<element_plan>();

        private static SimpleConnection db = new SimpleConnection();

        private HScrollBar scrollbar;

        private int current_scroll = 0;
        private int show_week = 23;
        private int n_week;

        private Color[] grid_colores = new Color[4];

        private CultureInfo c_info;
        private Calendar calendario;

        private DateTime primer_semana;
        private DateTime primer_lunes;
        private DateTime ultima_semana;

        public FormTPreventivo()
        {
            InitializeComponent();

            //Lista de maquinas
            leer_maquinas();

            maquina_select.AutoCompleteSource = AutoCompleteSource.ListItems;
            maquina_select.AutoCompleteMode = AutoCompleteMode.Suggest;
            maquina_select.DataSource = maquinas;

            maquina_select.SelectionChangeCommitted += new EventHandler(maquina_selecionada);
            b_mandar.Click += new EventHandler(mandar_cambios_sql);

            //Calendario
            c_info = new CultureInfo("es-MX");
            calendario = c_info.Calendar;

            //Grid Configuracion
            configurar_grid();
            calcular_semanas_especiales(2022);
        }

        private List<element_plan> get_copy_list(List<element_plan> a) {
            List<element_plan> tmp = new List<element_plan>();

            foreach (element_plan ep in a) {
                tmp.Add(new element_plan(ep));
            }

            return tmp;
        }

        private void calcular_semanas_especiales(int year) {
            primer_semana = new DateTime(year, 1, 1);

            if ((int)primer_semana.DayOfWeek >= 4) {
                primer_semana = primer_semana.AddDays(8 - (int)primer_semana.DayOfWeek);
            }
            primer_lunes = primer_semana.AddDays(1 - (int)primer_semana.DayOfWeek);

            ultima_semana = new DateTime(year, 12, 31);
        }
        private bool leer_maquinas() {
            using (SqlConnection connection = db.get_connection()) {
                SqlCommand query = new SqlCommand("select Modelo from maquinas", connection);

                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e.Message);//<-Esto es temporal xD
                    //Mostrar error
                    return false;
                }

                using (SqlDataReader reader = query.ExecuteReader()) {
                    while (reader.Read()) {
                        try {
                            maquinas.Add((string)reader[0]);
                        }
                        catch (Exception e) {
                            Console.WriteLine("Error");
                        }

                    }
                }

                return true;
            }
        }
        private int query_reagendar(element_plan ep)
        {
            using (SqlConnection connection = db.get_connection())
            {
                string s_query = "update Reparacion set Fecha = @f where Folio = @fo";

                SqlCommand query = new SqlCommand(s_query, connection);

                query.Parameters.Add("@f", SqlDbType.DateTime);
                query.Parameters.Add("@fo", SqlDbType.Int);

                query.Parameters["@f"].Value = parse_semana(ep.semana);
                query.Parameters["@fo"].Value = ep.folio;

                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                    //Mostrar error
                }

                try
                {
                    return query.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                    //Mostrar error
                }

                return -1;
            }
        }
        private void query_eliminar(int folio) {
            using (SqlConnection connection = db.get_connection())
            {
                string s_query = "delete from Reparacion where Folio = @f";

                SqlCommand query = new SqlCommand(s_query, connection);

                query.Parameters.Add("@f", SqlDbType.Int);

                query.Parameters["@f"].Value = folio;

                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                    //Mostrar error
                }

                try
                {
                    query.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                    //Mostrar error
                }

            }
        }

        private DateTime parse_semana(int semana) {
            int _semana = semana - 1;
            return _semana == 1 ? primer_semana :
                   (_semana == n_week ? ultima_semana : primer_lunes.AddDays(7 * (semana - 1)));
        }
        private int query_agregar(string maquina, int semana, int plan) {
            using (SqlConnection connection = db.get_connection())
            {
                string s_query = "insert into Reparacion(Modelo_Maquina,tipo_Mantto,Fecha,Descripcion) values " +
                                  "(@m,'PREVENTIVO',@f,@p);\n" +
                                  "select Folio from Reparacion where Fecha = @f and tipo_Mantto = 'PREVENTIVO' and " +
                                  "Modelo_Maquina = @m and Descripcion = @p;";

                SqlCommand query = new SqlCommand(s_query, connection);

                query.Parameters.Add("@m", SqlDbType.VarChar);
                query.Parameters.Add("@f", SqlDbType.DateTime);
                query.Parameters.Add("@p", SqlDbType.VarChar);

                query.Parameters["@m"].Value = maquina;
                query.Parameters["@f"].Value = parse_semana(semana);
                query.Parameters["@p"].Value = parse_int_to_plan(plan);

                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                    //Mostrar error
                }

                int folio = -1;

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            folio = (int)reader[0];
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                        }

                    }
                }

                return folio;
            }
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
                        query_eliminar(iep.folio);
                    }
                }


                //Agregar datos
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
                        if (ep.update_to == -1)
                        {
                            //AGREGAR
                            int folio = query_agregar(maquina_select.SelectedItem as string, ep.semana, ep.plan);
                            Console.WriteLine("Regristro agregado: {0}", folio);
                            ep.folio = folio;
                        }else {
                            //REAGENDAR
                            int result = query_reagendar(ep);

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

            foreach (DataGridViewColumn c in plan_select.Columns)
            {
                c.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                c.DefaultCellStyle.SelectionForeColor = Color.Transparent;
                c.DefaultCellStyle.ForeColor = Color.Transparent;

                c.Name = i.ToString();
                c.Width = 30;
                c.ReadOnly = true;
                i++;
            }
        }

        private void scroll_fake(object sender, ScrollEventArgs e) {
            procesar_lista_grid(scrollbar.Value);

            current_scroll = scrollbar.Value;

            grid_column_enumerate(current_scroll);
        }

        private void plan_grid_adjust(int n_semanas) {
            plan_select.ColumnCount = n_semanas;

            grid_column_enumerate(0);

            int w = (plan_select.Columns[0].Width * plan_select.ColumnCount) + plan_select.RowHeadersWidth;
            int h = (plan_select.Rows[0].Height * plan_select.RowCount) + plan_select.ColumnHeadersHeight;

            plan_select.Width = w;
            plan_select.Height = h;
        }

        private void limpiar_grid_element(element_plan ep){
            int semana_r = ep.semana - current_scroll - 1;
            plan_select.Rows[ep.plan].Cells[semana_r].Style.BackColor = Color.White;
            plan_select.Rows[ep.plan].Cells[semana_r].Style.SelectionBackColor = Color.White;
        }

        private void modificar_plan(object sender, DataGridViewCellMouseEventArgs e) {
            bool is_cell = e.RowIndex >= 0 && e.ColumnIndex >= 0;
            //REAGENDAR y AGREGAR
            if (is_cell && is_selected &&  e.Button == MouseButtons.Left)
            {
                element_plan tmp = new element_plan(e.ColumnIndex + 1 + current_scroll, e.RowIndex, -1);

                bool rep = false;
                foreach (element_plan ep in current_query)
                {
                    if (ep == tmp)
                    {
                        rep = true;
                        //REAGENDAR
                        using (FormRePreventivo reagendar = new FormRePreventivo(n_week))
                        {
                            reagendar.SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);

                            DialogResult result = reagendar.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                Console.WriteLine("Reagendar a {0}", reagendar.semana_registrada);
                                limpiar_grid_element(ep);
                                if (ep.folio != -1)
                                    ep.insert_update(reagendar.semana_registrada);
                                else
                                    ep.semana = reagendar.semana_registrada;
                            }
                        }
                        break;
                    }
                }

                if (rep == false)
                {
                    //AGREGAR
                    current_query.Add(tmp);
                }

            }//ELIMINAR
            else if (is_cell && is_selected && e.Button == MouseButtons.Right) {
                element_plan tmp = new element_plan(e.ColumnIndex + 1 + current_scroll, e.RowIndex, -1);

                int i = 0;
                bool rep = false;
                foreach (element_plan ep in current_query)
                {
                    if (ep == tmp)
                    {
                        limpiar_grid_element(ep);
                        rep = true;
                        break;
                    }
                    i++;
                }

                if (rep){
                    //ELIMINAR
                    current_query.RemoveAt(i);
                    Console.WriteLine("Eliminar");
                }
            }
            else if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                //Si es la primera semana
                string inicio;
                string fin;

                int semana = e.ColumnIndex + current_scroll + 1;

                if (semana == 1)
                {
                    inicio = primer_semana.ToString("m", c_info);
                }
                else
                {
                    inicio = primer_lunes.AddDays(7 * (current_scroll + e.ColumnIndex)).ToString("m", c_info);
                }

                int semana_numero = current_scroll + e.ColumnIndex + 1;

                if (semana == n_week)
                {
                    fin = ultima_semana.ToString("m", c_info);
                }
                else {

                    fin = primer_lunes.AddDays((7 * (current_scroll + e.ColumnIndex + 1)) - 1).ToString("m", c_info);
                }

                MessageBox.Show("          Semana " + semana_numero.ToString() + "\nInicia: " + inicio + "\nTermina: " + fin);
            }
            else
            {
                MessageBox.Show("Seleccione una maquina,para modificar");
            }

            procesar_lista_grid(current_scroll);
        }

        private int parse_plan(string plan_name) {
            switch (plan_name[0])
            {
                case 'A':
                case 'a':
                    return 0;
                case 'B':
                case 'b':
                    return 1;
                case 'C':
                case 'c':
                    return 2;
                case 'D':
                case 'd':
                    return 3;
            }
            return -1;
        }

        private string parse_int_to_plan(int plan) {
            switch (plan)
            {
                case 0:
                    return "A";
                case 1:
                    return "B";
                case 2:
                    return "C";
                case 3:
                    return "D";
            }
            return "ERROR";
        }

        private void procesar_lista_grid(int new_sc_i) {
            foreach (element_plan ep in current_query) {

                if (ep.plan == -1) continue;

                int pre_semana = ep.semana - 1 - current_scroll;
                int pos_semana = ep.semana - 1 - new_sc_i;
                //Limpiar Celda anterior
                if (pre_semana >= 0 && pre_semana < show_week) {
                    plan_select.Rows[ep.plan].Cells[pre_semana].Style.BackColor = Color.White;
                    plan_select.Rows[ep.plan].Cells[pre_semana].Style.SelectionBackColor = Color.White;
                }
                    

                if (pos_semana >= 0 && pos_semana < show_week) {
                    plan_select.Rows[ep.plan].Cells[pos_semana].Style.BackColor = grid_colores[ep.plan];
                    plan_select.Rows[ep.plan].Cells[pos_semana].Style.SelectionBackColor = grid_colores[ep.plan];
                }
                    
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
                    plan_select.Rows[ep.plan].Cells[pre_semana].Style.BackColor = Color.White;
                    plan_select.Rows[ep.plan].Cells[pre_semana].Style.SelectionBackColor = Color.White;
                }
            }
        }

        private void maquina_selecionada(object sender, EventArgs e) {
            //Obtener la maquina
            string select_maquina = (sender as ComboBox).SelectedItem as string;
            //Obtener el year
            int year = year_select.Value.Year;
            calcular_semanas_especiales(year);
            //Obtener el numero de semanas
            n_week = calendario.GetWeekOfYear(ultima_semana, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);

            Console.WriteLine(n_week);
            scrollbar.Minimum = 0;
            scrollbar.Maximum = n_week - show_week;

            using (SqlConnection connection = db.get_connection()) {
                string s_query = "select Fecha,Descripcion,Folio from Reparacion where " +
                                 "year(Fecha) = @f and tipo_Mantto = 'PREVENTIVO' and Modelo_Maquina = @m";

                SqlCommand query = new SqlCommand(s_query, connection);

                query.Parameters.Add("@f", SqlDbType.Int);
                query.Parameters.Add("@m", SqlDbType.VarChar);

                query.Parameters["@f"].Value = year;
                query.Parameters["@m"].Value = select_maquina;

                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                    //Mostrar error
                }

                //Borramos registros anteriores
                limpiar_grid();
                in_query.Clear();
                current_query.Clear();

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            int real_semana = calendario.GetWeekOfYear((DateTime)reader[0], CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);
                            in_query.Add(new element_plan(real_semana, parse_plan((string)reader[1]),(int)reader[2]));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                        }

                    }
                }

                current_query = get_copy_list(in_query);

                procesar_lista_grid(current_scroll);

                is_selected = true;
            }

        }

        private void configurar_grid() {
            plan_select.CellMouseDoubleClick += new DataGridViewCellMouseEventHandler(modificar_plan);

            plan_select.ScrollBars = ScrollBars.None;

            plan_select.AllowUserToAddRows = false;
            plan_select.AllowUserToDeleteRows = false;
            plan_select.AllowUserToOrderColumns = false;
            plan_select.AllowUserToResizeColumns = false;
            plan_select.AllowUserToResizeRows = false;
            plan_select.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            plan_select.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            plan_select.RowHeadersWidth = 80;

            plan_select.RowCount = 4;
            plan_grid_adjust(show_week);

            plan_select.Rows[0].HeaderCell.Value = "Plan A ";
            plan_select.Rows[1].HeaderCell.Value = "Plan B ";
            plan_select.Rows[2].HeaderCell.Value = "Plan C ";
            plan_select.Rows[3].HeaderCell.Value = "Plan D ";

            plan_select.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            plan_select.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            plan_select.DefaultCellStyle.ForeColor = Color.Transparent;
            plan_select.DefaultCellStyle.BackColor = Color.White;

            //Agregar ScrollBar
            scrollbar = new HScrollBar();

            scrollbar.Size = new Size(plan_select.Width - plan_select.RowHeadersWidth, 20);
            scrollbar.Location = new Point(plan_select.Location.X + plan_select.RowHeadersWidth,
                                           plan_select.Location.Y + plan_select.Size.Height);
            scrollbar.LargeChange = 1;
            scrollbar.Minimum = 0;
            scrollbar.Maximum = 10;

            Controls.Add(scrollbar);
            //Recolocar boton
            int end_y = scrollbar.Top + scrollbar.Height + 20;
            b_mandar.Top = end_y;
            

            scrollbar.Scroll += new ScrollEventHandler(scroll_fake);

            grid_colores[0] = Color.Coral;
            grid_colores[1] = Color.Magenta;
            grid_colores[2] = Color.Teal;
            grid_colores[3] = Color.SaddleBrown;
        }
    }
}
