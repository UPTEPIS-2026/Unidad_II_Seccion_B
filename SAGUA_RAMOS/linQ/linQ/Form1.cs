using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace linQ
{
    public partial class Form1 : Form
    {
        List<Producto> listaProductos = new List<Producto>();

        
        public Form1()
        {
            InitializeComponent();
            CargarDatos();

        }
        private void CargarDatos()
        {
            listaProductos.Clear();

            listaProductos.Add(new Producto { Codigo = "00000001", Nombre = "Portátil HP Pavilion", Categoria = "Electrónica", Marca = "HP" });

            listaProductos.Add(new Producto { Codigo = "20010002", Nombre = "Samsung Galaxy A54", Categoria = "Smartphone", Marca = "Samsung" });

            listaProductos.Add(new Producto { Codigo = "20020003", Nombre = "Monitor Dell 27\"", Categoria = "Computadoras", Marca = "Dell" });

            listaProductos.Add(new Producto { Codigo = "20020004", Nombre = "Auriculares Logitech G733", Categoria = "Periféricos", Marca = "Logitech" });

            listaProductos.Add(new Producto { Codigo = "20030107", Nombre = "Tablet Apple iPad Air", Categoria = "Electrónica", Marca = "Apple" });

            listaProductos.Add(new Producto { Codigo = "30010010", Nombre = "Teclado Mecánico Razer", Categoria = "Periféricos", Marca = "Razer" });

            listaProductos.Add(new Producto { Codigo = "30010011", Nombre = "Mouse Gamer Redragon", Categoria = "Periféricos", Marca = "Redragon" });

            listaProductos.Add(new Producto { Codigo = "30010012", Nombre = "Disco SSD 1TB Kingston", Categoria = "Almacenamiento", Marca = "Kingston" });

            listaProductos.Add(new Producto { Codigo = "30010013", Nombre = "Memoria RAM 16GB Corsair", Categoria = "Computadoras", Marca = "Corsair" });

            listaProductos.Add(new Producto { Codigo = "30010014", Nombre = "Smart TV LG 55\"", Categoria = "Audio y Video", Marca = "LG" });

            listaProductos.Add(new Producto { Codigo = "30010015", Nombre = "Impresora Epson L3250", Categoria = "Oficina", Marca = "Epson" });

            listaProductos.Add(new Producto { Codigo = "30010016", Nombre = "Laptop Lenovo IdeaPad 3", Categoria = "Computadoras", Marca = "Lenovo" });

            
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e, string rutaImagen)
        {
            
            
        }

        private void txtBuscarP_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarP.Text.ToLower();

            var resultado = listaProductos.Where(p =>
                (p.Nombre != null && p.Nombre.ToLower().Contains(filtro)) ||
                (p.Codigo != null && p.Codigo.ToLower().Contains(filtro)) ||
                (p.Marca != null && p.Marca.ToLower().Contains(filtro)) ||
                (p.Categoria != null && p.Categoria.ToLower().Contains(filtro))
            ).ToList();

            dgvProductos.DataSource = resultado;

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarP.Text;

            var resultado = listaProductos.Where(p =>
                (p.Nombre != null && p.Nombre.ToLower().Contains(filtro.ToLower())) ||
                (p.Codigo != null && p.Codigo.ToLower().Contains(filtro.ToLower())) ||
                (p.Marca != null && p.Marca.ToLower().Contains(filtro.ToLower())) ||
                (p.Categoria != null && p.Categoria.ToLower().Contains(filtro.ToLower()))
            ).ToList();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = resultado;

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Producto p = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;

                txtCodigoP.Text = p.Codigo;
                txtNombreP.Text = p.Nombre;
                txtMarcaP.Text = p.Marca;
                txtCategoriaP.Text = p.Categoria;
            }
        }
        private void LimpiarCampos()
        {
            txtCodigoP.Clear();
            txtNombreP.Clear();
            txtMarcaP.Clear();
            txtCategoriaP.Clear();
        }
        private void btnAniadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoP.Text) ||
        string.IsNullOrWhiteSpace(txtNombreP.Text) ||
        string.IsNullOrWhiteSpace(txtMarcaP.Text) ||
        string.IsNullOrWhiteSpace(txtCategoriaP.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            // Crear nuevo producto
            Producto nuevo = new Producto()
            {
                Codigo = txtCodigoP.Text,
                Nombre = txtNombreP.Text,
                Marca = txtMarcaP.Text,
                Categoria = txtCategoriaP.Text
            };

            // Agregar a la lista
            listaProductos.Add(nuevo);

            // Refrescar DataGrid
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;

            // Limpiar campos
            LimpiarCampos();

            MessageBox.Show("Producto agregado correctamente");
        }

        private void btnVerFicha_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                Producto p = (Producto)dgvProductos.CurrentRow.DataBoundItem;

                FrmFichaProducto ficha = new FrmFichaProducto();
                ficha.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un producto");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
