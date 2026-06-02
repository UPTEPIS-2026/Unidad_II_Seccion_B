using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace maquinaexpendedora
{
    public partial class Form1 : Form
    {
        double credito = 0;
        List<Producto> productos = new List<Producto>();
        List<Venta> ventas = new List<Venta>();
        public Form1()
        {
            InitializeComponent();
        }
        void ActualizarCredito()
        {
            lblCredito.Text = "S/ " + credito.ToString("0.00");
        }
        void AgregarMoneda(double monto)
        {
            credito += monto;

            ActualizarCredito();

            lblMensaje.ForeColor = Color.Green;

            lblMensaje.Text = "Crédito actualizado";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "Inserte monedas";
            txtCodigo.CharacterCasing = CharacterCasing.Upper;


            productos.Add(new Producto("A1", "Coca Cola", 3.50, 10));
            productos.Add(new Producto("A2", "Pepsi", 3.00, 10));
            productos.Add(new Producto("A3", "papas lays", 2.50, 10));
            productos.Add(new Producto("A4", "snikers", 3.50, 10));
            productos.Add(new Producto("A5", "agua", 1.50, 10));
            productos.Add(new Producto("A6", "jugo", 2.00, 10));

            productos.Add(new Producto("B1", "Oreo", 2.00, 10));
            productos.Add(new Producto("B2", "Wafer", 1.50, 10));
            productos.Add(new Producto("B3", "M&M's", 3.00, 10));
            productos.Add(new Producto("B4", "KitKat", 3.00, 10));
            productos.Add(new Producto("B5", "Gatorade", 4.50, 10));
            productos.Add(new Producto("B6", "Pringles", 5.00, 10));
        

            CrearProductos();
            CargarVentas();

            dgvReporte.AutoSizeColumnsMode =
            
            DataGridViewAutoSizeColumnsMode.Fill;

            dgvReporte.RowHeadersVisible = false;

            dgvReporte.ReadOnly = true;

        }
        void CargarVentas()
        {
            if (!File.Exists("ventas.txt"))
            {
                return;
            }

            string[] lineas =
                File.ReadAllLines("ventas.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split('|');

                Venta v = new Venta(
                    datos[0],
                    datos[1],
                    Convert.ToDouble(datos[2])
                );

                v.Fecha = Convert.ToDateTime(datos[3]);

                ventas.Add(v);
            }
        }
        void GuardarVenta(Venta v)
        {
            string texto =
                v.CodigoProducto + "|" +
                v.NombreProducto + "|" +
                v.Precio + "|" +
                v.Fecha;

            File.AppendAllText(
                "ventas.txt",
                texto + Environment.NewLine);
        }

        private void CrearProductos()
        {
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            credito += 5;
            ActualizarCredito();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            credito += 2;
            ActualizarCredito();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            credito += 1;
            ActualizarCredito();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            credito += 0.50;
            ActualizarCredito();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            credito += 0.20;
            ActualizarCredito();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            credito += 0.10;
            ActualizarCredito();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gpbMonedas_Enter(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            Producto p = productos.FirstOrDefault(x => x.Codigo == codigo);

            if (p == null)
            {
                lblMensaje.Text = "Producto no encontrado";
                return;
            }

            if (p.Stock <= 0)
            {
                lblMensaje.Text = "Sin stock";
                return;
            }

            if (credito < p.Precio)
            {
                lblMensaje.Text = "Crédito insuficiente";
                return;
            }

            credito -= p.Precio;

            double vuelto = credito;

            p.Stock--;


            Venta nuevaVenta = new Venta(
            p.Codigo,
            p.Nombre,
            p.Precio);

            ventas.Add(nuevaVenta);

            GuardarVenta(nuevaVenta);

            lblVuelto.Text = "S/ " + vuelto.ToString("0.00");

            lblMensaje.Text =
                "Producto entregado";

            credito = 0;

            ActualizarCredito();
        }

        private void lblVuelto_Click(object sender, EventArgs e)
        {
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (rbtnDia.Checked)
            {
                var reporteDia = ventas
                    .Where(v => v.Fecha.Date ==
                                DateTime.Now.Date)
                    .Select(v => new
                    {
                        FECHA = v.Fecha.ToShortDateString(),
                        CODIGO = v.CodigoProducto,
                        PRODUCTO = v.NombreProducto,
                        Precio = "S/ " + v.Precio.ToString("0.00")
                    })
                    .ToList();

                dgvReporte.DataSource = null;

                dgvReporte.DataSource = reporteDia;
            }

            else if (rbtnMes.Checked)
            {
                var reporteMes = ventas
                    .Where(v =>
                        v.Fecha.Month == DateTime.Now.Month
                        &&
                        v.Fecha.Year == DateTime.Now.Year)
                    .Select(v => new
                    {
                        FECHA = v.Fecha.ToShortDateString(),
                        CODIGO = v.CodigoProducto,
                        PRODUCTO = v.NombreProducto,
                        Precio = "S/ " + v.Precio.ToString("0.00")
                    })
                    .ToList();

                dgvReporte.DataSource = null;

                dgvReporte.DataSource = reporteMes;
            }

            else if (rbtnAno.Checked)
            {
                var reporteAno = ventas
                    .Where(v =>
                        v.Fecha.Year == DateTime.Now.Year)
                    .Select(v => new
                    {
                        FECHA = v.Fecha.ToShortDateString(),
                        CODIGO = v.CodigoProducto,
                        PRODUCTO = v.NombreProducto,
                        Precio = "S/ " + v.Precio.ToString("0.00")
                    })
                    .ToList();

                dgvReporte.DataSource = null;

                dgvReporte.DataSource = reporteAno;
            }

            else
            {
                MessageBox.Show(
                    "Seleccione un reporte");
            }
        }

        private void rbtnDia_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
