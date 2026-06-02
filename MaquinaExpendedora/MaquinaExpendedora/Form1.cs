namespace MaquinaExpendedora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        List<Producto> listaProductos = new List<Producto>();
        decimal credito = 0;
        decimal totalVentas = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Productos de ejemplo
            listaProductos.Add(new Producto { Codigo = "1", Nombre = "Galleta", Precio = 1.50m });
            listaProductos.Add(new Producto { Codigo = "2", Nombre = "Chocolate", Precio = 2.00m });
            listaProductos.Add(new Producto { Codigo = "3", Nombre = "Gaseosa", Precio = 3.50m });
            listaProductos.Add(new Producto { Codigo = "4", Nombre = "Agua", Precio = 1.00m });
            listaProductos.Add(new Producto { Codigo = "5", Nombre = "Papas", Precio = 2.50m });
            listaProductos.Add(new Producto { Codigo = "6", Nombre = "Caramelo", Precio = 0.50m });

            MostrarProductos();
        }

        private void MostrarProductos()
        {
            panelProductos.Controls.Clear();

            int y = 10;

            foreach (var p in listaProductos)
            {
                Label lbl = new Label();
                lbl.Text = $"Código: {p.Codigo} | {p.Nombre} - S/ {p.Precio}";
                lbl.Location = new Point(10, y);
                lbl.AutoSize = true;

                panelProductos.Controls.Add(lbl);
                y += 30;
            }
        }

        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBoxSeleccion.Text += btn.Text;
        }
        private void panelProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (textBoxSeleccion.Text.Length > 0)
            {
                textBoxSeleccion.Text = textBoxSeleccion.Text.Substring(0, textBoxSeleccion.Text.Length - 1);
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string codigo = textBoxSeleccion.Text;

            var producto = listaProductos.Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                if (credito >= producto.Precio)
                {
                    credito -= producto.Precio;
                    totalVentas += producto.Precio;

                    MessageBox.Show($"Producto entregado: {producto.Nombre}");
                }
                else
                {
                    MessageBox.Show("Crédito insuficiente");
                }
            }
            else
            {
                MessageBox.Show("Código inválido");
            }

            textBoxSeleccion.Clear();
        }

        private void AgregarDinero()
        {
            try
            {
                decimal monto = Convert.ToDecimal(textBoxDinero.Text);

                // Validar monedas permitidas
                if (monto == 5 || monto == 2 || monto == 1 || monto == 0.5m || monto == 0.2m || monto == 0.1m)
                {
                    credito += monto;
                    MessageBox.Show($"Crédito actual: S/ {credito}");
                }
                else
                {
                    MessageBox.Show("Moneda no válida");
                }

                textBoxDinero.Clear();
            }
            catch
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Vuelto: S/ {credito}");
            credito = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
