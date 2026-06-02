using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Negocio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //se modifica por la version
        SqlConnection conexion = new SqlConnection("Server=DESKTOP-O13P0GC;Database=NEGOCIO;Trusted_Connection=True;TrustServerCertificate=True;");
        //SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS; database=NEGOCIO; integrated security=true; Encrypt=false");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "insert into productos values (" + txtCodigo.Text + ", '" + txtNombre.Text + "', '" + txtMarca.Text + "', " + txtPrecio.Text + ")";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("RegistrSo Completado");
            conexion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "delete from productos where codigo= " + txtCodigo.Text + "";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
            conexion.Close();
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
        }
    }
}
