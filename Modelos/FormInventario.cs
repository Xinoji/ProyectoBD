using ProyectoBD.BD;
using ProyectoBD.Logica;
using System;
using System.Data;
using System.Drawing;
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
            setTheme();
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
                
                SqlCommand command = new SqlCommand("Update Refaccion set Stock=@Stock,precio=@precio,Descripcion=@Descripcion,cant_min=@cant_min, cant_max=@cant_max  where codigo=@codigo; ", conexion);
                command.Parameters.AddWithValue("@Stock", dgvinventario.Rows[i].Cells[1].Value ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@precio", dgvinventario.Rows[i].Cells[2].Value ?? (object)DBNull.Value);
                //command.Parameters.AddWithValue("@precioT", dgvinventario.Rows[i].Cells[3].Value);
                command.Parameters.AddWithValue("@Descripcion", dgvinventario.Rows[i].Cells[4].Value ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@cant_min", dgvinventario.Rows[i].Cells[5].Value ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@cant_max", dgvinventario.Rows[i].Cells[6].Value ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("codigo", dgvinventario.Rows[i].Cells[0].Value ?? (object)DBNull.Value);               
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            }
            MessageBox.Show("Actualizado");
        }
        public void UpdateSuma()
        {


                SqlCommand command = new SqlCommand("UPDATE Refaccion SET Stock = Stock + @Parm1  where codigo=@codigo; ", conexion);
                command.Parameters.AddWithValue("@Parm1", int.Parse(txtCantidad.Text));
                command.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                conexion.Open();
                command.ExecuteNonQuery();
                conexion.Close();
            
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



        private void btnSumar_Click(object sender, EventArgs e)
        {
            UpdateSuma();
            ReloadTable();
        }

        private void setTheme()
        {
            var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);
            var lightlight = ControlPaint.LightLight(themeColor);
            var lightdarkdarkColor = ControlPaint.Light(ControlPaint.Dark(darkColor));
            var darklightlight = ControlPaint.Dark(lightlight);
            var lightlightInvert = ControlPaint.LightLight(ControlPaint.Dark(WinTheme.InvertMeAColour(themeColor)));

            BackColor = darkColor;


            btnaActualizar.BackColor = themeColor;
            btnaActualizar.FlatAppearance.BorderColor = lightColor;
            btnBuscar.BackColor = themeColor;
            btnBuscar.FlatAppearance.BorderColor = lightColor;
            btnSumar.BackColor = themeColor;
            btnSumar.FlatAppearance.BorderColor = lightColor;
            txtCodigo.BackColor = themeColor;
            txtCantidad.BackColor = themeColor;


            dgvinventario.BackgroundColor = lightdarkdarkColor;
            dgvinventario.DefaultCellStyle.BackColor = lightdarkdarkColor;
            dgvinventario.DefaultCellStyle.ForeColor = Color.White;
            dgvinventario.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvinventario.DefaultCellStyle.SelectionBackColor = lightlightInvert;
            dgvinventario.ColumnHeadersDefaultCellStyle.BackColor = lightdarkdarkColor;
            dgvinventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvinventario.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dgvinventario.ColumnHeadersDefaultCellStyle.SelectionBackColor = lightdarkdarkColor;

            dgvinventario.GridColor = darkColor;
        }
    }


}
