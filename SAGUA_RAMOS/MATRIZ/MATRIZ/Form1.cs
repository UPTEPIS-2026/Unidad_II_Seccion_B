using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MATRIZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración inicial de los DataGridView
            ConfigurarDGV(dgvMatrizA);
            ConfigurarDGV(dgvMatrizB);
            ConfigurarDGV(dgvResultado);
        }

        private void ConfigurarDGV(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
        }

        private void btnCrearMatriz_Click(object sender, EventArgs e)
        {
            try
            {
                int filas = int.Parse(txtFilas.Text);
                int columnas = int.Parse(txtColumnas.Text);

                if (filas <= 0 || columnas <= 0) throw new Exception("Las dimensiones deben ser mayores a 0.");

                GenerarMatrizEnDGV(dgvMatrizA, filas, columnas);
                GenerarMatrizEnDGV(dgvMatrizB, filas, columnas);
                GenerarMatrizEnDGV(dgvResultado, filas, columnas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerarMatrizEnDGV(DataGridView dgv, int filas, int columnas)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            for (int j = 0; j < columnas; j++)
            {
                dgv.Columns.Add("col" + j, "");
            }

            for (int i = 0; i < filas; i++)
            {
                dgv.Rows.Add();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMatrizA.Rows.Count == 0 || dgvMatrizB.Rows.Count == 0)
                {
                    MessageBox.Show("Primero debe crear las matrices.");
                    return;
                }

                // Crear objetos Matriz (POO)
                Matriz matrizA = DGVAMatriz(dgvMatrizA);
                Matriz matrizB = DGVAMatriz(dgvMatrizB);

                // Multiplicar usando el método de la clase (Requisito 2 y 5)
                Matriz resultado = matrizA.Multiplicar(matrizB);

                // Mostrar resultado en el DGV
                MatrizADGV(resultado, dgvResultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al multiplicar: " + ex.Message, "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Matriz DGVAMatriz(DataGridView dgv)
        {
            int filas = dgv.Rows.Count;
            int columnas = dgv.Columns.Count;
            Matriz m = new Matriz(filas, columnas);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    string valor = dgv.Rows[i].Cells[j].Value?.ToString() ?? "0";
                    if (int.TryParse(valor, out int n))
                    {
                        m[i, j] = n;
                    }
                    else
                    {
                        m[i, j] = 0;
                    }
                }
            }
            return m;
        }

        private void MatrizADGV(Matriz m, DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            for (int j = 0; j < m.Columnas; j++)
            {
                dgv.Columns.Add("col" + j, "");
            }

            for (int i = 0; i < m.Filas; i++)
            {
                int rowIndex = dgv.Rows.Add();
                for (int j = 0; j < m.Columnas; j++)
                {
                    dgv.Rows[rowIndex].Cells[j].Value = m[i, j];
                }
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtFilas.Clear();
            txtColumnas.Clear();
            dgvMatrizA.Columns.Clear();
            dgvMatrizB.Columns.Clear();
            dgvResultado.Columns.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMatrizA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtIngresaDatosA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
