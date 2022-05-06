using ProyectoBD.BD;
using ProyectoBD.Logica;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ProyectoBD.Logica.refacciones;
namespace ProyectoBD.Modelos
{

    public partial class FormInventario : Form
    {
        SqlConnection conexion = new SqlConnection("Server =localhost\\SQLEXPRESS; Database = Lito; Trusted_Connection = True; ");
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

        public void UpdateD()
        {
            for (int i = 0; i <= dgvinventario.Rows.Count - 1; i++)
            {
                SqlCommand command = new SqlCommand("Update Refaccion set Stock=@Stock,precio=@precio,Descripcion=@Descripcion where codigo=@codigo; ", conexion);
                command.Parameters.AddWithValue("@Stock", dgvinventario.Rows[i].Cells[1].Value ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@precio", dgvinventario.Rows[i].Cells[2].Value ?? (object)DBNull.Value);
                //command.Parameters.AddWithValue("@precioT", dgvinventario.Rows[i].Cells[3].Value);
                command.Parameters.AddWithValue("@Descripcion", dgvinventario.Rows[i].Cells[4].Value ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("codigo", dgvinventario.Rows[i].Cells[0].Value ?? (object)DBNull.Value);
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
            MessageBox.Show("Actualizado");
        }

        private void btnaActualizar_Click(object sender, EventArgs e)
        {
            UpdateD();

            ReloadTable();
        }

        public void buscarRefaccion()
        {
            SqlCommand command = new SqlCommand("Select * from Refaccion where codigo=@parm1", conexion);
            command.Parameters.AddWithValue("@parm1", txtCodigo.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvinventario.DataSource = dt;
            dgvinventario.AllowUserToAddRows = false;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            buscarRefaccion();
        }


    }


}
