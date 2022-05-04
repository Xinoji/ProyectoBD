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
    public struct refaccionesData
    {
        string codigo;
        int stock;
        decimal precio;
        decimal precioT;
        string descripcion;
    }

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

        /*
        public void Upload(/*string Codigo/*, int Stock, decimal Precio, decimal PrecioT,string Descripcion)
        {
            using(var conexion= GetConnection())
            {
                conexion.Open();
                using(var command = new SqlCommand())
                {
                    command.Connection = conexion;
                    command.CommandText = "update descripcion set=@descripcion where codigo = @codigo ";
                    command.Parameters.Add("@descripcion", System.Data.SqlDbType.VarChar).Value =Descripcion;
                    command.ExecuteNonQuery();

                }
            }
        }*/

        /*
        public void Upload(string Codigo, int Stock, decimal Precio, decimal PrecioT,string Descripcion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "update refaccion set codigo = @codigo,Stock=@Stock, precio = @precio, precio_T = @precio_T, Descripcion = @Descripcion where codigo = @codigo";
                    command.Parameters.Add("@codigo", System.Data.SqlDbType.VarChar).Value = Codigo;
                    command.Parameters.Add("@Stock", System.Data.SqlDbType.Int).Value = Stock;
                    command.Parameters.Add("@precio", System.Data.SqlDbType.Decimal).Value = Precio;
                    command.Parameters.Add("@precio_T", System.Data.SqlDbType.Decimal).Value = PrecioT;
                    command.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar).Value = Descripcion;
                    command.ExecuteNonQuery();
                }
            }

        }*/

        

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
