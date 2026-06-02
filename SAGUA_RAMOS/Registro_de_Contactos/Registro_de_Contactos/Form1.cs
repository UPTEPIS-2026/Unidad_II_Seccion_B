using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Contactos
{
    public partial class Form1 : Form
    {
        // Lista dinámica de contactos (POO y Colecciones dinámicas)
        private BindingList<Contact> listaContactos = new BindingList<Contact>();
        private int proximoId = 1;

       
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            // Configurar DataGridView
            dgvListaContactos.DataSource = listaContactos;
            dgvListaContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListaContactos.MultiSelect = false;

            // Suscribir eventos
            btnAgregar.Click += btnAgregar_Click_1;
            
            btnActualizar.Click += btnActualizar_Click_1;
            btnEliminar.Click += btnEliminar_Click_1;
            btnLimpiar.Click += btnLimpiar_Click_1;
            dgvListaContactos.RowHeaderMouseClick += dgvListaContactos_RowHeaderMouseClick;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
        }
        
       
       

        // Validaciones de datos
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtNumContacto.Text) || string.IsNullOrEmpty(cmbGenero.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Nombre, Apellido, Teléfono y Género).");
                return false;
            }
            return true;
        }

        // Limpiar campos de la interfaz
        

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Contact c = new Contact
                {
                    IdContacto = proximoId++,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    NumContacto = txtNumContacto.Text,
                    Direccion = txtDireccion.Text,
                    Genero = cmbGenero.Text
                };
                listaContactos.Add(c);
                MessageBox.Show("Contacto agregado exitosamente.");
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtIdContacto.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumContacto.Text = "";
            txtDireccion.Text = "";
            cmbGenero.SelectedIndex = -1;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdContacto.Text))
            {
                MessageBox.Show("Por favor, seleccione un contacto de la lista para eliminar.");
                return;
            }

            int id = int.Parse(txtIdContacto.Text);
            Contact contactoParaEliminar = listaContactos.FirstOrDefault(c => c.IdContacto == id);

            if (contactoParaEliminar != null)
            {
                listaContactos.Remove(contactoParaEliminar);
                MessageBox.Show("Contacto eliminado exitosamente.");
                LimpiarCampos();
            }
        }

        private void dgvListaContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dgvListaContactos.Rows.Count)
            {
                txtIdContacto.Text = dgvListaContactos.Rows[rowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvListaContactos.Rows[rowIndex].Cells[1].Value.ToString();
                txtApellido.Text = dgvListaContactos.Rows[rowIndex].Cells[2].Value.ToString();
                txtNumContacto.Text = dgvListaContactos.Rows[rowIndex].Cells[3].Value.ToString();
                txtDireccion.Text = dgvListaContactos.Rows[rowIndex].Cells[4].Value.ToString();
                cmbGenero.Text = dgvListaContactos.Rows[rowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdContacto.Text))
            {
                MessageBox.Show("Por favor, seleccione un contacto de la lista para actualizar.");
                return;
            }

            if (ValidarCampos())
            {
                int id = int.Parse(txtIdContacto.Text);
                Contact contactoParaActualizar = listaContactos.FirstOrDefault(c => c.IdContacto == id);

                if (contactoParaActualizar != null)
                {
                    contactoParaActualizar.Nombre = txtNombre.Text;
                    contactoParaActualizar.Apellido = txtApellido.Text;
                    contactoParaActualizar.NumContacto = txtNumContacto.Text;
                    contactoParaActualizar.Direccion = txtDireccion.Text;
                    contactoParaActualizar.Genero = cmbGenero.Text;

                    dgvListaContactos.Refresh();
                    MessageBox.Show("Contacto actualizado exitosamente.");
                    LimpiarCampos();
                }
            }
        }

        private void txtIdContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = txtBuscar.Text.ToLower();
            if (!string.IsNullOrEmpty(keyword))
            {
                var filteredList = listaContactos.Where(c =>
                    c.Nombre.ToLower().Contains(keyword) ||
                    c.Apellido.ToLower().Contains(keyword) ||
                    c.NumContacto.Contains(keyword) ||
                    c.Direccion.ToLower().Contains(keyword)
                ).ToList();
                dgvListaContactos.DataSource = new BindingList<Contact>(filteredList);
            }
            else
            {
                dgvListaContactos.DataSource = listaContactos;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
