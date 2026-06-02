using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Negocio
{
    public partial class Negocio_version3 : Form
    {
        public Negocio_version3()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Server=DESKTOP-O13P0GC;Database=NEGOCIO;Trusted_Connection=True;TrustServerCertificate=True;");

        private void Negocio_version3_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();
            CargarVentas();
        }

        #region Clientes
        private void CargarClientes()
        {
            try
            {
                string consulta = "SELECT * FROM clientes";
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-O13P0GC;Database=NEGOCIO;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    conn.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgvClientes.DataSource = dt;
                    dgvClientes.AutoGenerateColumns = true;
                    dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dt.Rows.Count > 0)
                    {
                        DataRow primeraFila = dt.Rows[0];
                        txtIdCliente.Text = primeraFila["id"].ToString();
                        txtNombreCliente.Text = primeraFila["nombre"].ToString();
                        txtTelefonoCliente.Text = primeraFila["telefono"].ToString();
                        txtEmailCliente.Text = primeraFila["email"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "INSERT INTO clientes VALUES (" + txtIdCliente.Text + ", '" + txtNombreCliente.Text + "', '" + txtTelefonoCliente.Text + "', '" + txtEmailCliente.Text + "')";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado");
                conexion.Close();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "DELETE FROM clientes WHERE id = " + txtIdCliente.Text;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado");
                conexion.Close();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "UPDATE clientes SET nombre='" + txtNombreCliente.Text + "', telefono='" + txtTelefonoCliente.Text + "', email='" + txtEmailCliente.Text + "' WHERE id=" + txtIdCliente.Text;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cant = comando.ExecuteNonQuery();
                if (cant > 0)
                    MessageBox.Show("Cliente modificado");
                conexion.Close();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
                txtIdCliente.Text = fila.Cells["id"].Value.ToString();
                txtNombreCliente.Text = fila.Cells["nombre"].Value.ToString();
                txtTelefonoCliente.Text = fila.Cells["telefono"].Value.ToString();
                txtEmailCliente.Text = fila.Cells["email"].Value.ToString();
            }
        }
        #endregion

        #region Productos
        private void CargarProductos()
        {
            try
            {
                string consulta = "SELECT * FROM productos";
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-O13P0GC;Database=NEGOCIO;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    conn.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgvProductos.DataSource = dt;
                    dgvProductos.AutoGenerateColumns = true;
                    dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dt.Rows.Count > 0)
                    {
                        DataRow primeraFila = dt.Rows[0];
                        txtCodigoProducto.Text = primeraFila["codigo"].ToString();
                        txtNombreProducto.Text = primeraFila["nombre"].ToString();
                        txtMarcaProducto.Text = primeraFila["marca"].ToString();
                        txtPrecioProducto.Text = primeraFila["precio"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "INSERT INTO productos VALUES (" + txtCodigoProducto.Text + ", '" + txtNombreProducto.Text + "', '" + txtMarcaProducto.Text + "', " + txtPrecioProducto.Text + ")";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto agregado");
                conexion.Close();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "DELETE FROM productos WHERE codigo = " + txtCodigoProducto.Text;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado");
                conexion.Close();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "UPDATE productos SET nombre='" + txtNombreProducto.Text + "', marca='" + txtMarcaProducto.Text + "', precio=" + txtPrecioProducto.Text + " WHERE codigo=" + txtCodigoProducto.Text;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cant = comando.ExecuteNonQuery();
                if (cant > 0)
                    MessageBox.Show("Producto modificado");
                conexion.Close();
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                txtCodigoProducto.Text = fila.Cells["codigo"].Value.ToString();
                txtNombreProducto.Text = fila.Cells["nombre"].Value.ToString();
                txtMarcaProducto.Text = fila.Cells["marca"].Value.ToString();
                txtPrecioProducto.Text = fila.Cells["precio"].Value.ToString();
            }
        }
        #endregion

        #region Ventas
        private void CargarVentas()
        {
            try
            {
                string consulta = "SELECT * FROM ventas";
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-O13P0GC;Database=NEGOCIO;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    conn.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgvVentas.DataSource = dt;
                    dgvVentas.AutoGenerateColumns = true;
                    dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dt.Rows.Count > 0)
                    {
                        DataRow primeraFila = dt.Rows[0];
                        txtIdVenta.Text = primeraFila["id"].ToString();
                        txtProductoVenta.Text = primeraFila["producto"].ToString();
                        txtCantidadVenta.Text = primeraFila["cantidad"].ToString();
                        txtTotalVenta.Text = primeraFila["total"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "INSERT INTO ventas VALUES (" + txtIdVenta.Text + ", '" + txtProductoVenta.Text + "', " + txtCantidadVenta.Text + ", " + txtTotalVenta.Text + ")";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Venta agregada");
                conexion.Close();
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "DELETE FROM ventas WHERE id = " + txtIdVenta.Text;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Venta eliminada");
                conexion.Close();
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnModificarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string consulta = "UPDATE ventas SET producto='" + txtProductoVenta.Text + "', cantidad=" + txtCantidadVenta.Text + ", total=" + txtTotalVenta.Text + " WHERE id=" + txtIdVenta.Text;
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int cant = comando.ExecuteNonQuery();
                if (cant > 0)
                    MessageBox.Show("Venta modificada");
                conexion.Close();
                CargarVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvVentas.Rows[e.RowIndex];
                txtIdVenta.Text = fila.Cells["id"].Value.ToString();
                txtProductoVenta.Text = fila.Cells["producto"].Value.ToString();
                txtCantidadVenta.Text = fila.Cells["cantidad"].Value.ToString();
                txtTotalVenta.Text = fila.Cells["total"].Value.ToString();
            }
        }
        #endregion
    }
}
