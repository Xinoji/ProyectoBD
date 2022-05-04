using ProyectoBD.BD;
using ProyectoBD.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoBD.Logica.refacciones;

namespace ProyectoBD.Modelos
{

    public partial class FormInventario : Form
    {
        SqlConnection connection = new SqlConnection("Server = localhost\\SQLEXPRESS; Database = Lito; Trusted_Connection = True; ");
        private refaccionesData datos;
        refacciones refac = new refacciones();
        public FormInventario()
        {
            InitializeComponent();

        }
        public void ReloadTable(){
            dgvinventario.DataSource = refac.MostrarRefacciones();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void dgvinventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valor = DataGridViewUtils.GetValorCelda(dgvinventario,0);
            txtCodigo.Text = valor;
            Console.WriteLine(valor);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateD();
        }

        public void UpdateD()
        {
                for (int i = 0; i <= dgvinventario.Rows.Count - 1; i++)
                {
                    SqlCommand command = new SqlCommand("Update refaccion set Stock=@Stock,precio=@precio,Descripcion=@Descripcion where codigo=@codigo; ",connection);
                    command.Parameters.AddWithValue("@Stock", dgvinventario.Rows[i].Cells[1].Value);
                    command.Parameters.AddWithValue("@precio", dgvinventario.Rows[i].Cells[2].Value);
                    //command.Parameters.AddWithValue("@precio_T", dgvinventario.Rows[i].Cells[3].Value); 
                    command.Parameters.AddWithValue("@Descripcion", dgvinventario.Rows[i].Cells[4].Value);
                    command.Parameters.AddWithValue("@codigo", dgvinventario.Rows[i].Cells[0].Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            MessageBox.Show("Actualizado");

        }

    }
}
