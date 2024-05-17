using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoBD.BD;
using Npgsql;

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
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    
                    command.CommandText = "select * from " + from;

                    var resultTable = new DataTable();
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);

                    adapter.Fill(resultTable);
                    tabla = resultTable;
                    connection.Close();
                    CloseSSH();
                    return resultTable;
                }
                

            }
        }

        public void insertOperador(string nombre, string tipo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into operador values (@operador,@tipo);";
                    command.Parameters.Add("@operador", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nombre;
                    command.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = tipo;
                    command.ExecuteNonQuery();

                }
            }

        }

        public void updateOperador(string nombre, string tipo, string where) 
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update [operador] set [nombre] = @Nombre, [Tipo de Maquinaria] = @Tipo where [nombre] = @Where";
                    command.Parameters.Add("@Nombre", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nombre;
                    command.Parameters.Add("@Tipo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = tipo;
                    command.Parameters.Add("@Where", NpgsqlTypes.NpgsqlDbType.Varchar).Value = where;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void insertMecanico(string nombre, string estudios, DateTime fNac)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into mecanico values (@operador,@tipo,@fNac);";
                    command.Parameters.Add("@operador", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nombre;
                    command.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estudios;
                    command.Parameters.Add("@fNac", NpgsqlTypes.NpgsqlDbType.Date).Value = fNac;
                    command.ExecuteNonQuery();

                }
            }

        }

        public void updateMecanico(string nombre, string estudios, DateTime fNac, string where)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update [mecanico] set [nombre] = @Nombre, [Estudios] = @Estudio, [F_Nac] = @fNac where [nombre] = @Where";
                    command.Parameters.Add("@Nombre", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nombre;
                    command.Parameters.Add("@Estudio", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estudios;
                    command.Parameters.Add("@fNac", NpgsqlTypes.NpgsqlDbType.Date).Value = fNac;
                    command.Parameters.Add("@Where", NpgsqlTypes.NpgsqlDbType.Varchar).Value = where;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void insertMaquina (string modelo, decimal tiempo, string tipo, string nSerie, int ancho, int alto)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "insert into maquinas values (@modelo,@tiempo,@tipo,@serie,@ancho,@alto);";
                    command.Parameters.Add("@modelo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = modelo;
                    command.Parameters.Add("@tiempo", NpgsqlTypes.NpgsqlDbType.Numeric).Value = tiempo;
                    command.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = tipo;
                    command.Parameters.Add("@serie", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nSerie;
                    command.Parameters.Add("@ancho", NpgsqlTypes.NpgsqlDbType.Integer).Value = ancho;
                    command.Parameters.Add("@alto", NpgsqlTypes.NpgsqlDbType.Integer).Value = alto;
                    command.ExecuteNonQuery();

                }
            }

        }

        public void updateMaquina(string modelo, decimal tiempo, string tipo, string nSerie, int ancho, int alto, string where)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update [maquinas] set [Modelo] = @modelo, [Tiempo_Produccion] = @tiempo, [tipo] = @tipo, [N_Serie] = @serie,[Etiqueta_Ancho] = @ancho, [EtiquetaAlto] = @alto where [modelo]  = @Where";
                    command.Parameters.Add("@modelo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = modelo;
                    command.Parameters.Add("@tiempo", NpgsqlTypes.NpgsqlDbType.Numeric).Value = tiempo;
                    command.Parameters.Add("@tipo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = tipo;
                    command.Parameters.Add("@serie", NpgsqlTypes.NpgsqlDbType.Varchar).Value = nSerie;
                    command.Parameters.Add("@ancho", NpgsqlTypes.NpgsqlDbType.Integer).Value = ancho;
                    command.Parameters.Add("@alto", NpgsqlTypes.NpgsqlDbType.Integer).Value = alto;
                    command.Parameters.Add("@Where", NpgsqlTypes.NpgsqlDbType.Varchar).Value = where;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void deleteMecanico(string where)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from [mecanico] where [nombre]  = @Where";
                    command.Parameters.Add("@Where", NpgsqlTypes.NpgsqlDbType.Varchar).Value = where;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void deleteOperador(string where)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from [operador] where [nombre]  = @Where";
                    command.Parameters.Add("@Where", NpgsqlTypes.NpgsqlDbType.Varchar).Value = where;
                    command.ExecuteNonQuery();

                }
            }
        }

        public void deleteMaquina(string where)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "delete from [maquinas] where [modelo]  = @Where";
                    command.Parameters.Add("@Where", NpgsqlTypes.NpgsqlDbType.Varchar).Value = where;
                    command.ExecuteNonQuery();

                }
            }
        }
    }
    
}
