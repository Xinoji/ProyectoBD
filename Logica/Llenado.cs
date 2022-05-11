using ProyectoBD.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace ProyectoBD.Logica
{
    public class Reporte {
        public int folio { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public string causa { get; set; }
        public string solucion { get; set; }
        public string maquina { get; set; }
        public string mecanico { get; set; }
        public string operador { get; set; }
        public decimal parada { get; set; }
        public decimal reparacion { get; set; }

        public Reporte() {
            folio = -1;
            fecha = new DateTime();
            descripcion = "";
            causa = "";
            solucion = "";
            maquina = "";
            operador = "";
            parada = 0;
            reparacion = 0;
        }
    }

    public class update_element {
        public string name { get; set; }
        public string value { get; set; }

        public update_element(string n, string v) {
            name = n;
            value = v;
        }

        public update_element() {
            name = "";
            value = "";
        }

        public static bool operator ==(update_element a, update_element b) {
            return a.name == b.name;
        }
        public static bool operator !=(update_element a, update_element b)
        {
            return a.name != b.name;
        }
    }
    internal class Llenado : DbConnection
    {
        private void update_table(int folio, ref List<update_element> lista, string table) {
            if (lista.Count == 0) return;

            using (SqlConnection connection = GetConnection())
            {
                string text_query = "update " + table + " set ";

                bool primero = true;
                foreach (update_element ue in lista)
                {
                    if (!primero)
                    {
                        text_query += ',';
                    }
                    else primero = false;

                    Console.WriteLine("[{0}][{1}]", ue.name, ue.value);

                    text_query += ue.name + " = " + ue.value;

                }

                text_query += " where Folio = @f;";

                Console.WriteLine(text_query);

                SqlCommand query = new SqlCommand(text_query, connection);

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
                    if (query.ExecuteNonQuery() == 0)
                    {
                        Console.WriteLine("No se actualizo xD");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                    //Mostrar error
                }
            }
        }
        public void update_correctivo(int folio,ref List<update_element> list_reparacion,ref List<update_element> list_reporte) {
            update_table(folio,ref list_reparacion,"Reparacion");
            update_table(folio,ref list_reporte, "Reporte");
        }
        public int insert_reparacion(ref List<update_element> lista){
            if (lista.Count == 0) return -1;

            using (SqlConnection connection = GetConnection())
            {
                string text_query = "insert into Reparacion(";

                //(TIPO,TIPO)
                bool primero = true;
                foreach (update_element ue in lista)
                {
                    if (!primero)
                    {
                        text_query += ',';
                    }
                    else primero = false;

                    text_query += ue.name;
                }

                text_query += ",tipo_Mantto) values (";

                //VALUES
                primero = true;
                foreach (update_element ue in lista)
                {
                    if (!primero)
                    {
                        text_query += ',';
                    }
                    else primero = false;

                    text_query += ue.value;
                }

                text_query += ",'CORRECTIVO') select @@IDENTITY;";

                Console.WriteLine(text_query);

                SqlCommand query = new SqlCommand(text_query, connection);

                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                    //Mostrar error
                }

                int new_folio = -1;

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            decimal tmp = (decimal)reader[0];
                            new_folio = (int)tmp;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                        }

                    }
                }

                return new_folio;
            }
        }
        public int insert_reporte(ref List<update_element> lista,int folio) {
            if (folio == -1) return -1;

            using (SqlConnection connection = GetConnection())
            {
                string text_query = "insert into Reporte(";

                //(TIPO,TIPO)
                bool primero = true;
                foreach (update_element ue in lista)
                {
                    if (!primero)
                    {
                        text_query += ',';
                    }
                    else primero = false;

                    text_query += ue.name;
                }

                if (!primero)
                {
                    text_query += ',';
                }

                text_query += "folio) values (";

                //VALUES
                primero = true;
                foreach (update_element ue in lista)
                {
                    if (!primero)
                    {
                        text_query += ',';
                    }
                    else primero = false;

                    text_query += ue.value;
                }

                if (!primero)
                {
                    text_query += ',';
                }

                text_query += "@f);";

                Console.WriteLine(text_query);

                SqlCommand query = new SqlCommand(text_query, connection);

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

                int new_folio = 0;

                try
                {
                    if (query.ExecuteNonQuery() == 0)
                    {
                        Console.WriteLine("No se creo xD");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                                                            //Mostrar error

                    new_folio = -1;
                }

                return new_folio;
            }
        }
        public int crear_correctivo(ref List<update_element> list_reparacion, ref List<update_element> list_reporte) {
            int folio = insert_reparacion(ref list_reparacion);
            insert_reporte(ref list_reporte,folio);

            return folio;
        }

        public List<string> get_list_query(string name, string table) {
            List<string> lista = new List<string>();

            using (SqlConnection connection = GetConnection()) { 
                string text_query = "select " + name + " from " + table;

                SqlCommand query = new SqlCommand(text_query, connection);

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
                            lista.Add((string)reader[0]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error" + ex.Message);//<-Esto es temporal xD
                        }

                    }
                }
            }


            return lista;
        }

        public Reporte get_reporte(int folio) {
            Reporte tmp_reporte = new Reporte();

            using (SqlConnection connection = GetConnection()) {
                string text_query = "select r.Folio,Fecha,Modelo_Maquina,Descripcion,nom_Mecanico,Operador,Tiempo_Parada,Tiempo_Reparacion,Causa,Solucion " + 
                                    "from Reporte as r inner join Reparacion as re on re.Folio = r.Folio where r.Folio = @f;";
                SqlCommand query = new SqlCommand(text_query, connection);

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

                using (SqlDataReader reader = query.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        try { tmp_reporte.folio = (int)reader[0]; } catch (Exception ex){ tmp_reporte.folio = -1; }
                        try { tmp_reporte.fecha = (DateTime)reader[1]; } catch (Exception ex) { tmp_reporte.fecha = DateTime.Today; }
                        try { tmp_reporte.maquina = (string)reader[2]; } catch (Exception ex) { tmp_reporte.maquina = ""; }
                        try { tmp_reporte.descripcion = (string)reader[3]; } catch (Exception ex) { tmp_reporte.descripcion = ""; }
                        try { tmp_reporte.mecanico = (string)reader[4]; } catch (Exception ex) { tmp_reporte.mecanico = ""; }
                        try { tmp_reporte.operador = (string)reader[5]; } catch (Exception ex) { tmp_reporte.operador = ""; }
                        try { tmp_reporte.parada = (decimal)reader[6]; } catch (Exception ex) { tmp_reporte.parada = 0; }
                        try { tmp_reporte.reparacion = (decimal)reader[7]; } catch (Exception ex) { tmp_reporte.reparacion = 0; }
                        try { tmp_reporte.causa = (string)reader[8]; } catch (Exception ex) { tmp_reporte.causa = ""; }
                        try { tmp_reporte.solucion = (string)reader[9]; } catch (Exception ex) { tmp_reporte.solucion = ""; }
                    }
                }

            }

            return tmp_reporte;
        }

    }

    

}
