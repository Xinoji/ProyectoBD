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

        public DbConnection() {
            connectionString = "Server=localhost\\SQLEXPRESS;Database=Lito;Trusted_Connection=True;";// conexion de la DB
        }

        protected SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }
    }
}
