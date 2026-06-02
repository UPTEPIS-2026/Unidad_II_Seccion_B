using System;

namespace Figuras
{
    // Clase base abstracta (POO: Abstracción)
    public abstract class Figura
    {
        public string Nombre { get; set; }

        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public virtual double CalcularVolumen() => 0; // Por defecto 0 si no es 3D
    }

    // --- FIGURAS 2D ---

    public class Cuadrado : Figura
    {
        private double lado;
        public Cuadrado(double lado) { this.lado = lado; Nombre = "Cuadrado"; }
        public override double CalcularArea() => lado * lado;
        public override double CalcularPerimetro() => 4 * lado;
    }

    public class Rectangulo : Figura
    {
        private double base_rect;
        private double altura;
        public Rectangulo(double b, double h) { base_rect = b; altura = h; Nombre = "Rectángulo"; }
        public override double CalcularArea() => base_rect * altura;
        public override double CalcularPerimetro() => 2 * (base_rect + altura);
    }

    public class Triangulo : Figura
    {
        private double base_tri;
        private double altura;
        public Triangulo(double b, double h) { base_tri = b; altura = h; Nombre = "Triángulo"; }
        public override double CalcularArea() => (base_tri * altura) / 2;
        public override double CalcularPerimetro() => 3 * base_tri; // Asumiendo equilátero para simplificar
    }

    public class Circulo : Figura
    {
        private double radio;
        public Circulo(double r) { radio = r; Nombre = "Círculo"; }
        public override double CalcularArea() => Math.PI * Math.Pow(radio, 2);
        public override double CalcularPerimetro() => 2 * Math.PI * radio;
    }

    // --- FIGURAS 3D (VOLUMEN) ---

    public class Esfera : Figura
    {
        private double radio;
        public Esfera(double r) { radio = r; Nombre = "Esfera"; }
        public override double CalcularArea() => 4 * Math.PI * Math.Pow(radio, 2);
        public override double CalcularPerimetro() => 0;
        public override double CalcularVolumen() => (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
    }

    public class Cubo : Figura
    {
        private double lado;
        public Cubo(double l) { lado = l; Nombre = "Cubo"; }
        public override double CalcularArea() => 6 * Math.Pow(lado, 2);
        public override double CalcularPerimetro() => 12 * lado;
        public override double CalcularVolumen() => Math.Pow(lado, 3);
    }

    public class Cilindro : Figura
    {
        private double radio;
        private double altura;
        public Cilindro(double r, double h) { radio = r; altura = h; Nombre = "Cilindro"; }
        public override double CalcularArea() => 2 * Math.PI * radio * (radio + altura);
        public override double CalcularPerimetro() => 0;
        public override double CalcularVolumen() => Math.PI * Math.Pow(radio, 2) * altura;
    }
}
