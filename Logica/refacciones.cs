using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBD.BD;

namespace ProyectoBD.Logica
{
    class refacciones : DbConnection
    {
        
        public DataTable MostrarRefacciones()
        {
            using (var conexion = GetConnection())
            {
                SqlCommand command = new SqlCommand("Select * from refaccion",conexion);
                SqlDataAdapter da = new SqlDataAdapter();
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
