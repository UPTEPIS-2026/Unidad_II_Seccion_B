using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Negocio
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection(
            "server=DESKTOP-9VVOH9L\\SQLEXPRESS; database=negocio; integrated security=true; TrustServerCertificate=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into productos values (" + txbCodigo.Text + ", '" + txbNombre.Text + "', '" + txbMarca.Text + "'," + txbPrecio.Text + ")";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Completado");
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "delete from productos where codigo=" + txbCodigo.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            conexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "update productos set codigo=" + txbCodigo.Text + ", nombre='" + txbNombre.Text + "', " +
                "marca='" + txbMarca.Text + "', precio=" + txbPrecio.Text + " where codigo=" + txbCodigo.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant > 0)
            {
                MessageBox.Show("Registro Modificado");
            }
            conexion.Close();
        }   
    }
}