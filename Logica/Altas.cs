using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBD.BD;
using System.Data.SqlClient;

namespace ProyectoBD.Logica 
{
    internal class Altas : DbConnection
    {

        //campos y propiedades
        public DataTable tabla { get; private set; }
        public Altas()
        {
            
        }

        public DataTable getTable(string from)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    
                    command.CommandText = "select * from " + from;

                    var resultTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(resultTable);
                    tabla = resultTable;
                    return resultTable;
                }
            }
        }

        public void insertOperador(string nombre, string tipo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into operador values (@operador,@tipo);";
                    command.Parameters.Add("@operador", System.Data.SqlDbType.VarChar).Value = nombre;
                    command.Parameters.Add("@tipo", System.Data.SqlDbType.VarChar).Value = tipo;
                    command.ExecuteNonQuery();

                }
            }

        }

        public void updateOperador(string nombre, string tipo, string where) 
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update [operador] set [nombre] = @Nombre, [Tipo de Maquinaria] = @Tipo where [nombre] = @Where";
                    command.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = nombre;
                    command.Parameters.Add("@Tipo", System.Data.SqlDbType.VarChar).Value = tipo;
                    command.Parameters.Add("@Where", System.Data.SqlDbType.VarChar).Value = where;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void insertMecanico(string nombre, string estudios, DateTime fNac)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into mecanico values (@operador,@tipo,@fNac);";
                    command.Parameters.Add("@operador", System.Data.SqlDbType.VarChar).Value = nombre;
                    command.Parameters.Add("@tipo", System.Data.SqlDbType.VarChar).Value = estudios;
                    command.Parameters.Add("@fNac", System.Data.SqlDbType.Date).Value = fNac;
                    command.ExecuteNonQuery();

                }
            }

        }

        public void updateMecanico(string nombre, string estudios, DateTime fNac, string where)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update [mecanico] set [nombre] = @Nombre, [Estudios] = @Estudio, [F_Nac] = @fNac where [nombre] = @Where";
                    command.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar).Value = nombre;
                    command.Parameters.Add("@Estudio", System.Data.SqlDbType.VarChar).Value = estudios;
                    command.Parameters.Add("@fNac", System.Data.SqlDbType.Date).Value = fNac;
                    command.Parameters.Add("@Where", System.Data.SqlDbType.VarChar).Value = where;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void insertMaquina (string modelo, decimal tiempo, string tipo, string nSerie, int ancho, int alto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into maquinas values (@modelo,@tiempo,@tipo,@serie,@ancho,@alto);";
                    command.Parameters.Add("@modelo", System.Data.SqlDbType.VarChar).Value = modelo;
                    command.Parameters.Add("@tiempo", System.Data.SqlDbType.Decimal).Value = tiempo;
                    command.Parameters.Add("@tipo", System.Data.SqlDbType.VarChar).Value = tipo;
                    command.Parameters.Add("@serie", System.Data.SqlDbType.VarChar).Value = nSerie;
                    command.Parameters.Add("@ancho", System.Data.SqlDbType.Int).Value = ancho;
                    command.Parameters.Add("@alto", System.Data.SqlDbType.Int).Value = alto;
                    command.ExecuteNonQuery();

                }
            }

        }

        public void updateMaquina(string modelo, decimal tiempo, string tipo, string nSerie, int ancho, int alto, string where)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update [maquinas] set [Modelo] = @modelo, [Tiempo_Produccion] = @tiempo, [tipo] = @tipo, [N_Serie] = @serie,[Etiqueta_Ancho] = @ancho, [EtiquetaAlto] = @alto where [modelo]  = @Where";
                    command.Parameters.Add("@modelo", System.Data.SqlDbType.VarChar).Value = modelo;
                    command.Parameters.Add("@tiempo", System.Data.SqlDbType.Decimal).Value = tiempo;
                    command.Parameters.Add("@tipo", System.Data.SqlDbType.VarChar).Value = tipo;
                    command.Parameters.Add("@serie", System.Data.SqlDbType.VarChar).Value = nSerie;
                    command.Parameters.Add("@ancho", System.Data.SqlDbType.Int).Value = ancho;
                    command.Parameters.Add("@alto", System.Data.SqlDbType.Int).Value = alto;
                    command.Parameters.Add("@Where", System.Data.SqlDbType.VarChar).Value = where;
                    command.ExecuteNonQuery();

                }
            }
        }
    }
    
}
