using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_U2
{
    public partial class Form1 : Form
    {
        List<Persona> listaPersonas = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
            dgvCabeza.AutoGenerateColumns = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona nuevaPersona = new Persona();
            nuevaPersona.Nombre = txtNombre.Text;
            nuevaPersona.Edad = int.Parse(txtEdad.Text);

            listaPersonas.Add(nuevaPersona);

            dgvCabeza.DataSource = null;
            dgvCabeza.DataSource = listaPersonas;

            txtNombre.Clear();
            txtEdad.Clear();
            txtNombre.Focus();
        }

        private void btnMayores_Click(object sender, EventArgs e)
        {
            var soloMayores = listaPersonas.Where(p => p.Edad >= 18).ToList();
            dgvCabeza.DataSource = null;
            dgvCabeza.DataSource = soloMayores;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower();
            var filtrados = listaPersonas.Where(p => p.Nombre.ToLower().Contains(busqueda)).ToList();
            dgvCabeza.DataSource = null;
            dgvCabeza.DataSource = filtrados;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            if (listaPersonas.Count > 0)
            {
                double promedio = listaPersonas.Average(p => p.Edad);

                // Aquí usamos el lblResultado para mostrar el dato
                lblResultado.Text = "Promedio: " + promedio.ToString("F1");
            }
            else
            {
                lblResultado.Text = "No hay datos";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(busqueda))
            {
                // Filtramos la lista global usando LINQ
                var filtrados = listaPersonas
                    .Where(p => p.Nombre.ToLower().Contains(busqueda))
                    .ToList();

                // Mostramos el resultado
                dgvCabeza.DataSource = null;
                dgvCabeza.DataSource = filtrados;
            }
            else
            {
                // Si el buscador está vacío, mostramos todos de nuevo
                dgvCabeza.DataSource = null;
                dgvCabeza.DataSource = listaPersonas;
            }
        }
    }
}
