using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ProyectoBD.BD;

namespace ProyectoBD.Logica
{
    class refacciones : DbConnection
    {
        
        public DataTable MostrarRefacciones()
        {
            using (var conexion = GetConnection())
            {
                NpgsqlCommand command = new NpgsqlCommand("Select * from refaccion",conexion);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = command;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt; 
            }

        }
        

        public class DataGridViewUtils
        {
            public static string GetValorCelda(DataGridView dgv, int num)
            {
                string valor = "";

                valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();

                return valor;
            }
        }

    }
}
