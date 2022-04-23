using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBD.BD;
namespace ProyectoBD.Logica

{
    public struct PreventivoData 
    {
        public string Plan;
        public string Maquina;
        public int Semana;
        public int Folio;
        public int Active;
    }
    public class PreventivoCheck : DbConnection
    {
        //Campos y Propiedades
        private int folio;
        
        
        //Constructor
        public PreventivoCheck(int Folio) 
        {
            folio = Folio;
        }

        //metodos publicos 

        public void Upload(decimal tReparacion, decimal tParada, string mecanico, DateTime nuevaFecha) {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "update Reparacion set Fecha = @fecha,Tiempo_Parada = @TParada, Tiempo_Reparacion = @TReparacion, nom_Mecanico = @Mecanico where Folio = @Folio";
                    command.Parameters.Add("@Folio", System.Data.SqlDbType.Int).Value = folio;
                    command.Parameters.Add("@Tparada", System.Data.SqlDbType.Decimal).Value = tParada;
                    command.Parameters.Add("@TReparacion", System.Data.SqlDbType.Decimal).Value = tReparacion;
                    command.Parameters.Add("@Mecanico", System.Data.SqlDbType.VarChar).Value = mecanico;
                    command.Parameters.Add("@fecha", System.Data.SqlDbType.Date).Value = nuevaFecha;
                    command.ExecuteNonQuery();
                    
                }
            }

        }
        public void Reagendar(DateTime nuevaFecha)
        {
            using (var connection = GetConnection())  
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "update Reparacion set Fecha = @Fecha where Folio = @Folio";
                    command.Parameters.Add("@Folio", System.Data.SqlDbType.Int).Value = folio;
                    command.Parameters.Add("@Fecha", System.Data.SqlDbType.Date).Value = nuevaFecha.AddDays(1 - (int)nuevaFecha.DayOfWeek);
                    
                    command.ExecuteNonQuery();

                }
            }

        }

        //Metodos privados

       

        
    }


}
