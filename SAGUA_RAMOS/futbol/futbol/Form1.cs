using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futbol
{
    public partial class Form1 : Form
    {
        private List<Jugador> listaJugadores;
        private int jugadorSeleccionadoIndex;

        public Form1()
        {
            InitializeComponent();
            listaJugadores = new List<Jugador>();
            jugadorSeleccionadoIndex = -1;
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvJugadores.AutoGenerateColumns = false;
            dgvJugadores.Columns.Clear();
            dgvJugadores.Columns.Add("Nombre", "Nombre");
            dgvJugadores.Columns.Add("Posicion", "Posición");
            dgvJugadores.Columns.Add("Numero", "Número");
            dgvJugadores.Columns.Add("Condicion", "Condición");
        }

        private void ActualizarDataGridView()
        {
            dgvJugadores.Rows.Clear();
            foreach (Jugador jugador in listaJugadores)
            {
                dgvJugadores.Rows.Add(jugador.Nombre, jugador.Posicion, jugador.NumeroCamiseta, jugador.Condicion);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPosicion.Clear();
            txtNumero.Clear();
            cmbCondicion.SelectedIndex = -1;
            jugadorSeleccionadoIndex = -1;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor ingrese el nombre del jugador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPosicion.Text))
            {
                MessageBox.Show("Por favor ingrese la posición", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPosicion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("Por favor ingrese el número de camiseta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }

            int numero;
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("Por favor ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
                return false;
            }

            if (cmbCondicion.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione la condición", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCondicion.Focus();
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Jugador nuevoJugador = new Jugador(
                    txtNombre.Text.Trim(),
                    txtPosicion.Text.Trim(),
                    int.Parse(txtNumero.Text),
                    cmbCondicion.SelectedItem.ToString()
                );

                listaJugadores.Add(nuevoJugador);
                ActualizarDataGridView();
                LimpiarCampos();
                MessageBox.Show("Jugador agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (jugadorSeleccionadoIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un jugador de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidarCampos())
            {
                listaJugadores[jugadorSeleccionadoIndex].Nombre = txtNombre.Text.Trim();
                listaJugadores[jugadorSeleccionadoIndex].Posicion = txtPosicion.Text.Trim();
                listaJugadores[jugadorSeleccionadoIndex].NumeroCamiseta = int.Parse(txtNumero.Text);
                listaJugadores[jugadorSeleccionadoIndex].Condicion = cmbCondicion.SelectedItem.ToString();

                ActualizarDataGridView();
                LimpiarCampos();
                MessageBox.Show("Jugador modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (jugadorSeleccionadoIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un jugador de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar este jugador?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                listaJugadores.RemoveAt(jugadorSeleccionadoIndex);
                ActualizarDataGridView();
                LimpiarCampos();
                MessageBox.Show("Jugador eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listaJugadores.Count)
            {
                jugadorSeleccionadoIndex = e.RowIndex;
                Jugador jugador = listaJugadores[jugadorSeleccionadoIndex];

                txtNombre.Text = jugador.Nombre;
                txtPosicion.Text = jugador.Posicion;
                txtNumero.Text = jugador.NumeroCamiseta.ToString();
                cmbCondicion.SelectedItem = jugador.Condicion;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
