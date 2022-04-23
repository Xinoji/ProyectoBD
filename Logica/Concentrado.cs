using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBD.BD;
using System.Windows;

namespace ProyectoBD.Logica
{
    internal class Concentrado : DbConnection
    {
        //campos y propiedades
        public List<string> Mecanicos { get; private set; }
        public List<string> Maquinas { get; private set; }
        public List<string> Tipos { get; private set; }
        public List<string> Operadores { get; private set; }
        public List<PreventivoData> preventivoDatas { get; private set; }
        public DataTable Reparacion;
        //constructor
        public Concentrado()
        {
            loadData();
        }

        private void loadData()
        {
            getMaquinas();
            getMecanicos();     
            getPreventivos();
            getOperadores();
            getTipo();
            
        }
        //Metodos Publicos

        /// <summary>
        /// Metodo para Buscar en la base de Datos
        /// </summary>
        public DataTable getReparaciones(string maquina, string mecanico, string operador, string tipo, DateTime startDate, DateTime endDate) 
        {
            string select, from, where;
            select = "select Repa.Folio, Fecha, Modelo_Maquina as 'Modelo Maquina', tipo_Mantto as 'Tipo Mantto', Tiempo_Parada as 'Tiempo Parada', Tiempo_Reparacion as 'Tiempo Reparacion',  case when tipo_Mantto = 'PREVENTIVO' then 'Plan ' + Descripcion else Descripcion end as 'Descripcion', nom_Mecanico as 'Mecanico' ";
            from =   "from Reparacion as Repa left join Reporte as Repo on Repa.Folio = Repo.Folio ";
            where =  "where (Fecha between @startDate and @endDate) ";

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    if (tipo != "PREVENTIVO")
                    {
                        select += ", Operador, Causa, Solucion ";
                    }
                    if (operador != "Operador")
                    {
                        where = where + "and (Repo.Operador = @operador) ";
                        command.Parameters.Add("@operador", SqlDbType.VarChar).Value = operador;
                       
                    }
                    if (tipo != "Tipo")
                    {
                        where = where + "and (Repa.tipo_Mantto = @tipo) ";
                        command.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo;
                        
                    }
                    if (maquina != "Maquinas")
                    {
                        where = where + "and (Repa.Modelo_Maquina = @maquina) ";
                        command.Parameters.Add("@maquina", SqlDbType.VarChar).Value = maquina;
                       
                    }
                    if (mecanico != "Mecanico")
                    {
                        where = where + "and (Repa.nom_Mecanico = @mecanico) ";
                        command.Parameters.Add("@mecanica", SqlDbType.VarChar).Value = mecanico;
                       
                    }
                    command.CommandText = select + from + where;
                    command.Parameters.Add("@startDate", SqlDbType.Date).Value = startDate;
                    command.Parameters.Add("@endDate", SqlDbType.Date).Value = endDate;


                    var resultTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(resultTable);
                    

                    Reparacion = resultTable;
                    return Reparacion;
                }
            }
            
        }
        //metodos privados
        private void getOperadores()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "select nombre " +
                        "from operador ";

                    var reader = command.ExecuteReader();

                    var resultTable = new List<string>();
                    resultTable.Add("Operador");
                    while (reader.Read())
                    {
                        resultTable.Add((string)reader[0]);
                    }

                    Operadores = resultTable;
                    reader.Close();
                }
            }
        }

        private void getTipo()
        {
            Tipos = new List<string>();
            Tipos.Add("Tipo");
            Tipos.Add("CORRECTIVO");
            Tipos.Add("PREVENTIVO");
        }
   
        private void getMaquinas()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "select Modelo " +
                        "from maquinas ";

                    var reader = command.ExecuteReader();

                    var resultTable = new List<string>();
                    resultTable.Add("Maquinas");
                    while (reader.Read())
                    {
                        resultTable.Add((string)reader[0]);
                    }

                    Maquinas = resultTable;
                    reader.Close();
                }
            }
        }

        private void getMecanicos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "select nombre " +
                        "from mecanico ";

                    var reader = command.ExecuteReader();

                    var resultTable = new List<string>();
                    resultTable.Add("Mecanico");
                    while (reader.Read())
                    {
                        resultTable.Add((string)reader[0]);
                    }

                    Mecanicos = resultTable;
                    reader.Close();
                }
            }
        }
        private void getPreventivos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "select Folio, Modelo_Maquina, Descripcion as 'Plan', Fecha, case when nom_Mecanico is null then 1 else 0 end " +
                        "from reparacion " +
                        "where (nom_Mecanico is null and Fecha < @endWeek) or (Fecha between @startWeek and @endWeek);"; //agregar between luners y viernes
                    command.Parameters.Add("@startWeek", System.Data.SqlDbType.Date).Value = DateTime.Now.AddDays(1 - (int)DateTime.Now.DayOfWeek);
                    command.Parameters.Add("@endWeek", System.Data.SqlDbType.Date).Value = DateTime.Now.AddDays(5 - (int)DateTime.Now.DayOfWeek);
                    var reader = command.ExecuteReader();

                    var resultTable = new List<PreventivoData>();

                    while (reader.Read()){
                        resultTable.Add(new PreventivoData() 
                        {
                            Folio = (int)reader[0],
                            Maquina = (string)reader[1],
                            Plan = (string)reader[2],
                            Semana = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear((DateTime)reader[3], CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday),
                            Active = (int)reader[4],                               
                    });
                    }
                    preventivoDatas = resultTable;

                }
            }
        }

    }
}
