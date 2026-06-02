using System;
using System.Data;
using System.Windows.Forms;

namespace tarea
{
    public partial class Form1 : Form
    {
        private DataTable conexionITTDataTable;

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
            BindControls();
        }

        private void InitializeDataTable()
        {
            conexionITTDataTable = new DataTable("alumnos");
            conexionITTDataTable.Columns.Add("NC", typeof(string));
            conexionITTDataTable.Columns.Add("Nombre", typeof(string));
            conexionITTDataTable.Columns.Add("Especialidad", typeof(string));
            conexionITTDataTable.Columns.Add("FechaNacimiento", typeof(string));
            conexionITTDataTable.Columns.Add("FechaIngreso", typeof(string));

            conexionITTDataTable.Rows.Add("123456", "Juan Pérez", "Sistemas", "01/01/2000", "01/08/2020");
            conexionITTDataTable.Rows.Add("654321", "María López", "Mecánica", "15/05/2001", "15/08/2021");

            alumnosBindingSource.DataSource = conexionITTDataTable;
        }

        private void BindControls()
        {
            txtNC.DataBindings.Add("Text", alumnosBindingSource, "NC");
            txtNombre.DataBindings.Add("Text", alumnosBindingSource, "Nombre");
            txtEspecialidad.DataBindings.Add("Text", alumnosBindingSource, "Especialidad");
            txtFechaNacimiento.DataBindings.Add("Text", alumnosBindingSource, "FechaNacimiento");
            txtFechaIngreso.DataBindings.Add("Text", alumnosBindingSource, "FechaIngreso");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarPosicion();
        }

        private void MostrarPosicion()
        {
            int iTotal = alumnosBindingSource.Count;
            int iPos;

            if (iTotal == 0)
            {
                lblPosicion.Text = "No registros";
            }
            else
            {
                iPos = alumnosBindingSource.Position + 1;
                lblPosicion.Text = iPos.ToString() + " de " + iTotal.ToString();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            alumnosBindingSource.Position = 0;
            MostrarPosicion();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            alumnosBindingSource.Position -= 1;
            MostrarPosicion();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            alumnosBindingSource.Position += 1;
            MostrarPosicion();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            alumnosBindingSource.Position = alumnosBindingSource.Count - 1;
            MostrarPosicion();
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            DataTable miTabla = conexionITTDataTable;
            DataRowCollection cfilas = miTabla.Rows;
            DataRow nuevaFila;

            try
            {
                nuevaFila = miTabla.NewRow();
                nuevaFila[0] = "0000000";
                nuevaFila[1] = "Nombre";
                nuevaFila[2] = "1";
                nuevaFila[3] = "01/01/1980";
                nuevaFila[4] = "01/01/1980";
                cfilas.Add(nuevaFila);
                btnUltimo.PerformClick();
                txtNC.Focus();
                MostrarPosicion();
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DataRowView vistaFilaActual;
            String NL = Environment.NewLine;

            if (MessageBox.Show("¿Desea borrar este registro?" + NL + "Buscar", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vistaFilaActual = (DataRowView)alumnosBindingSource.Current;
                if (vistaFilaActual != null)
                {
                    vistaFilaActual.Row.Delete();
                    MostrarPosicion();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valorBusqueda = txtBuscar.Text.Trim();
            
            if (string.IsNullOrEmpty(valorBusqueda))
            {
                MessageBox.Show("Ingrese un valor para buscar.");
                return;
            }

            DataRow[] filasEncontradas = conexionITTDataTable.Select($"NC = '{valorBusqueda}' OR Nombre LIKE '%{valorBusqueda}%'");

            if (filasEncontradas.Length > 0)
            {
                int indice = alumnosBindingSource.Find("NC", filasEncontradas[0]["NC"]);
                if (indice != -1)
                {
                    alumnosBindingSource.Position = indice;
                    MostrarPosicion();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron registros.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conexionITTDataTable.GetChanges() != null)
            {
                MessageBox.Show("Origen de datos actualizado...");
            }
        }
    }
}
