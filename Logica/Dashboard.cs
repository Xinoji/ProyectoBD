using ProyectoBD.BD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.Logica
{
    public struct HorasPorMaquina 
    {
        public string Maquina { get; set; }
        public decimal Horas { get; set; }
        public decimal Porcentaje { get; set; }
    }
    public struct PorcentajePorFecha
    {
        public decimal Porcentaje { get; set; }
        public string Fecha { get; set; }
    }

    public class Dashboard : DbConnection
    {
        //Campos y Propiedades
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public List<string> planA { get; private set; }
        public List<string> planB { get; private set; }
        public List<string> planC { get; private set; }
        public List<string> planD { get; private set; }    
        public List<KeyValuePair<string, decimal>> hrsParo { get; private set; }
        public List<HorasPorMaquina> hrsParoChart { get; private set; }

        public List<PorcentajePorFecha> dispoChart { get; private set; }
        //Constructor
        public Dashboard() {
            
        }
        
        //metodos Privados
        private void getPlanes()  // Falta Agregar Planes
        {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) 
                {
                   command.Connection = connection;
                   command.CommandText = "";
                }
            }
        }
        private int DiasLaborales(DateTime startDate, DateTime endDate) {
            // Calcular los dias entre las fechas
            int days = (endDate - startDate).Days;

            // Restar los Sabados y Domingos en los dias intermedios
            int weeks = days / 7;
            days = days - (weeks * 2);
            
            // Preparar Casos Especiales
            int startDay = (int)startDate.DayOfWeek;
            int endDay = (int)endDate.DayOfWeek;

            // eleminar un fin de semana no considerado  
            if (startDay - endDay > 1)
                days = days - 2;

            // eliminar el primer dia si es sabado pero termina antes del sabado
            if (startDay == 0 && endDay != 6)
                days = days - 1;

            // eleminiar el ultimo dia si es sabado pero inicia despues del sabado
            if (endDay == 6 && startDay != 0)
                days = days - 1;


            return days;
        }
        private int MesDiasLaborales(DateTime Mes)
        {

            return DiasLaborales(Mes.AddDays(-Mes.Day + 1), Mes.AddMonths(1).AddDays(-Mes.Day + 1));
        }
        private void getHrs() {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    decimal totalHoras;
                    command.Connection = connection;
                    command.CommandText = "select sum(Tiempo_Parada) as HrsParada " +
                        "from Reparacion " +
                        "where Fecha Between @startDate AND @endDate";

                    command.Parameters.Add("@startDate", System.Data.SqlDbType.Date).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.Date).Value = endDate;
                    try
                    {
                        totalHoras = (decimal)command.ExecuteScalar();
                    }
                    catch (Exception)
                    {
                        totalHoras = 0;

                    }
                   

                    command.Connection = connection;
                    command.CommandText = "select Modelo_Maquina, sum(Tiempo_Parada) as HrsParada " +
                        "from Reparacion " +
                        "where Fecha Between @startDate AND @endDate " +
                        "group by Modelo_Maquina ";


                    var reader = command.ExecuteReader();

                    var resultTable = new List<KeyValuePair<string, decimal>>();

                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<string, decimal>((string)reader[0],(decimal)reader[1]));
                    
                    }
                    hrsParo = resultTable;
                    reader.Close();

                    decimal total = 0;
                    hrsParoChart = (from lista in resultTable
                                    orderby lista.Value descending
                                    group lista by lista.Key
                                    into query
                                    select new HorasPorMaquina
                                    {
                                        Maquina = query.Key,
                                        Horas = query.ElementAt(0).Value,
                                        Porcentaje = (total += query.ElementAt(0).Value / totalHoras)*100
                                    }).ToList();
                    


                }
            }

        }
        private void getDisponibilidad()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    decimal totalProduccion;
                    int nDias;
                    command.Connection = connection;

                    command.CommandText = "select sum(Tiempo_Produccion) as Hrs " +
                        "from Maquinas ";


                    totalProduccion = (decimal)command.ExecuteScalar();


                    command.CommandText = "select Fecha, sum(Tiempo_Parada) as HrsParada " +
                        "from Reparacion " +
                        "where Fecha Between @startDate AND @endDate " +
                        "group by Fecha ";

                    command.Parameters.Add("@startDate", System.Data.SqlDbType.Date).Value = startDate;
                    command.Parameters.Add("@endDate", System.Data.SqlDbType.Date).Value = endDate;
                    var reader = command.ExecuteReader();

                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();

                    while (reader.Read())
                    {
                        resultTable.Add(new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1]));
                    }
                    reader.Close();
                    connection.Close();

                        

                    //Agrupar por Dias
                    if (numberDays <= 30)
                    {

                            dispoChart = (from lista in resultTable
                                          group lista by lista.Key.ToString("dd MMM")
                                          into query
                                          select new PorcentajePorFecha
                            {
                                Fecha = query.Key,
                                Porcentaje = (totalProduccion - query.Sum(amount => amount.Value)) / totalProduccion * 100

                            }).ToList();

                       
                    }

                    //Agrupar por Semanas
                    else if (numberDays <= 92)
                    {
                        dispoChart = (from lista in resultTable
                                      group lista by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                      lista.Key, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday)
                                      into query
                                      select new PorcentajePorFecha
                                      {
                                          Fecha = "Semana " + query.Key.ToString(),
                                          Porcentaje = ( (totalProduccion * 5) - query.Sum(amount => amount.Value) ) / (totalProduccion * 5) * 100
                                      }
                                      ).ToList();
                        
                    }

                    //Agrupar por Meses
                    else if (numberDays <= 365 * 2) 
                    {
                        bool isYear = numberDays <= 365;
                        dispoChart = (from lista in resultTable
                                      group lista by lista.Key.ToString("MMM yyyy")
                                      into query
                                      select new PorcentajePorFecha
                                      {
                                          Fecha = isYear ? query.Key.Substring(0, query.Key.IndexOf(" ")) : query.Key,
                                          Porcentaje = (totalProduccion * (nDias = MesDiasLaborales(Convert.ToDateTime(query.Key))) - query.Sum(amount => amount.Value)) / (totalProduccion * nDias) * 100
                                      }).ToList();
                    }

                }

            }




        } //Falta Tabla Maquinas
        
        public void LoadData(DateTime startDate, DateTime endDate) 
        {
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                getHrs();
                getDisponibilidad();

            }
        }
    }
}
