using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busquedaxgrupo
{
    public partial class Form1 : Form
    {
        List<Paciente> listaPacientes = new List<Paciente>();
        public Form1()
        {
            InitializeComponent();
            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            Random ran = new Random();
            string[] diagnosticos = { "COVID-19", "Gripe Común", "Anemia", "Hipertensión", "Diabetes" };
            string[] nombres = { "Juan", "Maria", "Pedro", "Ana", "Luis", "Elena", "Diego", "Carmen" };

            for (int i = 1; i <= 100; i++)
            {
                listaPacientes.Add(new Paciente
                {
            
                    id_paciente = 1000 + i,
                    nomb_pac = nombres[ran.Next(nombres.Length)],
                    apel_pac = "Apellido " + i,
                    edad_pac = ran.Next(1, 90),
                    CIE_10 = (i % 3 == 0) ? "COVID-19" : diagnosticos[ran.Next(diagnosticos.Length)]
                });
            }
            
            dgvListaGeneral.DataSource = listaPacientes.ToList();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbRangoEdad.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un rango de edad en el combo.");
                return;
            }

            string rango = cmbRangoEdad.SelectedItem.ToString();
            string filtroDiagnostico = txtCriterioDiagnostico.Text.Trim().ToUpper();

            int min = 0;
            int max = 0;

            switch (rango)
            {
                case "0-13": min = 0; max = 13; break;
                case "14-18": min = 14; max = 18; break;
                case "19-40": min = 19; max = 40; break;
                case "41-60": min = 41; max = 60; break;
                case "61 a +": min = 61; max = 150; break;
            }

            var pacientesFiltrados = from p in listaPacientes
                                     where p.edad_pac >= min && p.edad_pac <= max
                                     && p.CIE_10.ToUpper().Contains(filtroDiagnostico)
                                     select p;

            dgvListaGeneral.DataSource = null;
            dgvListaGeneral.DataSource = pacientesFiltrados.ToList();

            
            if (!pacientesFiltrados.Any())
            {
                MessageBox.Show("No hay pacientes en este rango con ese diagnóstico.");
            }
        }
    }
}
