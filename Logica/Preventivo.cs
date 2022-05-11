using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProyectoBD.BD;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace ProyectoBD.Logica
{
    public class element_plan
    {
        public int semana { get; set; }
        public int plan { get; set; }
        public int folio { get; set; }
        public int update_from { get; set; }
        public element_plan(int s, int p, int f) { semana = s; plan = p; folio = f; update_from = -1; }

        public element_plan(element_plan ep)
        {
            semana = ep.semana;
            plan = ep.plan;
            folio = ep.folio;
            update_from = ep.update_from;
        }
        public void insert_update(int u)
        {
            if (u == semana) return;

            if (update_from != -1)
                semana = u;
            else {
                int aux = semana;
                semana = u;
                update_from = aux;
            }
        }

        public int encontrado_en(List<element_plan> list) {
            int encontrado = -1;
            int i = 0;
            foreach (element_plan ep in list) {
                if (ep == this) {
                    encontrado = i;
                    break;
                }
                i++;
            }

            return encontrado;
        }

        public void autoinsert_in(ref List<reagendar_element> list) {
            foreach (reagendar_element re in list) {
                if (re == this) {
                    re.to = semana;
                    return;
                }
            }
            if(update_from != -1)
                list.Add(new reagendar_element(plan,update_from,semana));
        }

        public void autoquit_in(ref List<reagendar_element> list) {
            int i = 0;
            int index = -1;
            foreach (reagendar_element re in list)
            {
                if (re == this)
                {
                    index = i;
                    break;
                }
                i++;
            }
            if(index != -1)
                list.RemoveAt(index);
        }

        public static bool operator ==(element_plan a, element_plan b)
        {
            return a.semana == b.semana && a.plan == b.plan;
        }
        public static bool operator !=(element_plan a, element_plan b)
        {
            return a.semana != b.semana || a.plan != b.plan;
        }
    };
    public class reagendar_element {
        public int plan { get; set; }
        public int from { get; set; }
        public int to { get; set; }

        public reagendar_element()
        {
            plan = 0;
            from = -1;
            to = -1;
        }
        public reagendar_element(int p, int f, int t) {
            plan = p;
            from = f;
            to = t;
        }
        public static bool operator ==(reagendar_element a, element_plan b) {
            return a.from == b.update_from;
        }
        public static bool operator !=(reagendar_element a, element_plan b) {
            return a.from != b.update_from;
        }
    }
    internal class Preventivo : DbConnection
    {
        private DateTime primer_semana;
        private DateTime primer_lunes;
        public DateTime ultima_semana { get; set; }

        public CultureInfo c_info { get; set; }
        public Calendar calendario { get; set; }
        public int max_semana { get; set; }

        public Preventivo() {
            c_info = new CultureInfo("es-MX");
            calendario = c_info.Calendar;
        }
        public void calcular_semanas_especiales(int year)
        {
            primer_semana = new DateTime(year, 1, 1);

            if ((int)primer_semana.DayOfWeek > 1)
            {
                primer_semana = primer_semana.AddDays(8 - (int)primer_semana.DayOfWeek);
            }
            primer_lunes = primer_semana.AddDays(1 - (int)primer_semana.DayOfWeek);

            ultima_semana = new DateTime(year, 12, 31);

            max_semana = calendario.GetWeekOfYear(ultima_semana, CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);
        }
        public DateTime parse_semana(int semana)
        {
            int _semana = semana - 1;
            return _semana == 1 ? primer_semana :
                   (_semana == max_semana ? ultima_semana : primer_lunes.AddDays(7 * (semana - 1)));
        }
        public static int parse_plan(string plan_name)
        {
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

        public static string parse_int_to_plan(int plan)
        {
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

        public void get_limit_week(int semana,ref string primer_dia, ref string ultimo_dia) {
            if (semana == 1)
            {
                primer_dia = primer_semana.ToString("m", c_info);
            }
            else
            {
                primer_dia = primer_lunes.AddDays(7 * (semana - 1)).ToString("m", c_info);
            }

            if (semana == max_semana)
            {
                ultimo_dia = ultima_semana.ToString("m", c_info);
            }
            else
            {

                ultimo_dia = primer_lunes.AddDays((7 * semana) - 1).ToString("m", c_info);
            }
        }

        public void leer_preventivos(ref List<element_plan> in_query, int year, string maquina) {
            using (SqlConnection connection = GetConnection())
            {
                string s_query = "select Fecha,Descripcion,Folio from Reparacion where " +
                                 "year(Fecha) = @f and tipo_Mantto = 'PREVENTIVO' and Modelo_Maquina = @m";

                SqlCommand query = new SqlCommand(s_query, connection);

                query.Parameters.Add("@f", SqlDbType.Int);
                query.Parameters.Add("@m", SqlDbType.VarChar);

                query.Parameters["@f"].Value = year;
                query.Parameters["@m"].Value = maquina;

                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                    //Mostrar error
                }

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            int real_semana = calendario.GetWeekOfYear((DateTime)reader[0], CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);

                            in_query.Add(new element_plan(real_semana, parse_plan((string)reader[1]), (int)reader[2]));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                        }

                    }
                }

                
            }
        }

        public bool leer_maquinas(ref List<string> maquinas)
        {
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand query = new SqlCommand("select Modelo from maquinas", connection);

                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e.Message);//<-Esto es temporal xD
                    return false;
                }

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            maquinas.Add((string)reader[0]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Error");
                        }

                    }
                }

                return true;
            }
        }
        public int query_reagendar(element_plan ep)
        {
            using (SqlConnection connection = GetConnection())
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
        public void query_eliminar(int folio)
        {
            using (SqlConnection connection = GetConnection())
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

        public int query_agregar(string maquina, int semana, int plan)
        {
            using (SqlConnection connection = GetConnection())
            {
                string s_query = "insert into Reparacion(Modelo_Maquina,tipo_Mantto,Fecha,Descripcion) values " +
                                  "(@m,'PREVENTIVO',@f,@p) select @@IDENTITY;";

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
                            decimal tmp_folio = (decimal)reader[0];
                            folio = (int)tmp_folio;
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

    }
}
