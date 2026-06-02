using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Negocio
{
    public partial class Negocio_version2 : Form
    {
        public Negocio_version2()
        {
            InitializeComponent();
        }


        SqlConnection conexion = new SqlConnection("Server=DESKTOP-O13P0GC;Database=NEGOCIO;Trusted_Connection=True;TrustServerCertificate=True;");

        private void Negocio_version2_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into productos values (" + txtCodigo.Text + ", '" + txtNombre.Text + "', '" + txtMarca.Text + "', " + txtPrecio.Text + ")";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Completado");
            conexion.Close();
            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "delete from productos where codigo= " + txtCodigo.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            conexion.Close();
            CargarProductos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "update productos set codigo=" + txtCodigo.Text + ", nombre='" + txtNombre.Text + "', " +
                "marca='" + txtMarca.Text + "', precio=" + txtPrecio.Text + " where codigo=" + txtCodigo.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Registro Modificado");
            }
            conexion.Close();
            CargarProductos();
        }

        private void CargarProductos()
        {
            try
            {
                string consulta = "SELECT * FROM productos";
                using (SqlConnection conexion = new SqlConnection("Server=DESKTOP-O13P0GC;Database=NEGOCIO;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    conexion.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dtProductos = new DataTable();
                    adaptador.Fill(dtProductos);

                    dataGridView1.DataSource = dtProductos;
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dtProductos.Rows.Count > 0)
                    {
                        DataRow primeraFila = dtProductos.Rows[0];
                        txtCodigo.Text = primeraFila["codigo"].ToString();
                        txtNombre.Text = primeraFila["nombre"].ToString();
                        txtMarca.Text = primeraFila["marca"].ToString();
                        txtPrecio.Text = primeraFila["precio"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells["codigo"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtMarca.Text = fila.Cells["marca"].Value.ToString();
                txtPrecio.Text = fila.Cells["precio"].Value.ToString();
            }
        }
    }
}
