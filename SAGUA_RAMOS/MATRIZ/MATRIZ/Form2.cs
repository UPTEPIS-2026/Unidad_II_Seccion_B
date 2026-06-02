using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form2 : Form
    {
        private string figuraSeleccionada = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void btnFigura_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            figuraSeleccionada = btn.Text;
            ConfigurarEntradas(figuraSeleccionada);
            lblResultado.Text = "Resultado:";
        }

        private void ConfigurarEntradas(string figura)
        {
            // Ocultar todo primero
            lblMedida1.Visible = txtMedida1.Visible = false;
            lblMedida2.Visible = txtMedida2.Visible = false;
            txtMedida1.Clear();
            txtMedida2.Clear();

            switch (figura)
            {
                case "Cuadrado":
                case "Cubo":
                    lblMedida1.Text = "Lado:";
                    lblMedida1.Visible = txtMedida1.Visible = true;
                    break;
                case "Circulo":
                case "Esfera":
                    lblMedida1.Text = "Radio:";
                    lblMedida1.Visible = txtMedida1.Visible = true;
                    break;
                case "Rectangulo":
                case "Triangulo":
                case "Cilindro":
                    lblMedida1.Text = figura == "Cilindro" ? "Radio:" : "Base:";
                    lblMedida2.Text = "Altura:";
                    lblMedida1.Visible = txtMedida1.Visible = true;
                    lblMedida2.Visible = txtMedida2.Visible = true;
                    break;
            }
        }

        private void txtMedida_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            if (string.IsNullOrEmpty(figuraSeleccionada)) return;

            try
            {
                double m1 = 0, m2 = 0;
                double.TryParse(txtMedida1.Text, out m1);
                double.TryParse(txtMedida2.Text, out m2);

                Figura f = null;

                // POO: Polimorfismo y Creación de Objetos
                switch (figuraSeleccionada)
                {
                    case "Cuadrado": f = new Cuadrado(m1); break;
                    case "Rectangulo": f = new Rectangulo(m1, m2); break;
                    case "Triangulo": f = new Triangulo(m1, m2); break;
                    case "Circulo": f = new Circulo(m1); break;
                    case "Esfera": f = new Esfera(m1); break;
                    case "Cubo": f = new Cubo(m1); break;
                    case "Cilindro": f = new Cilindro(m1, m2); break;
                }

                if (f != null)
                {
                    string res = $"Figura: {f.Nombre}\n";
                    res += $"Área: {f.CalcularArea():F2}\n";
                    
                    if (f.CalcularPerimetro() > 0)
                        res += $"Perímetro: {f.CalcularPerimetro():F2}\n";
                    
                    if (f.CalcularVolumen() > 0)
                        res += $"Volumen: {f.CalcularVolumen():F2}";

                    lblResultado.Text = res;
                }
            }
            catch { lblResultado.Text = "Error en datos"; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMedida1.Clear();
            txtMedida2.Clear();
            lblResultado.Text = "Resultado:";
            figuraSeleccionada = "";
            ConfigurarEntradas("");
        }
    }
}
