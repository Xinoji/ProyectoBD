using Npgsql;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD.BD
{
    public abstract class DbConnection
    {
        private readonly string connectionString;
        private SshClient client;
        private ForwardedPort port;
        public DbConnection() {
            connectionString = "Server=127.0.0.1;Database=lito;Port=15432;User Id=jona;Password=litografia44.;CommandTimeout=60;Timeout=60" ; ;// conexion de la DB
        }

        ~DbConnection()
        {
            client.Disconnect();
            port.Stop();
        }


        protected NpgsqlConnection GetConnection() {
            client = new SshClient("89.116.51.99", "jona", "litografia44.");
            client.Connect();

            if (!client.IsConnected)
                Console.WriteLine("No se conecto SSH");
            else Console.WriteLine("Se conecto SSH");

            port = new ForwardedPortLocal("127.0.0.1", 15432, "127.0.0.1", 5432);
            client.AddForwardedPort(port);
            port.Start();

            return new NpgsqlConnection(connectionString);
        }

        protected void CloseSSH() 
        { 
            port.Stop();
            client.Disconnect();
        }

        
    }
}
