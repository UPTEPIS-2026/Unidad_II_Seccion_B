using System;

namespace futbol
{
    public class Jugador
    {
        private string nombre;
        private string posicion;
        private int numeroCamiseta;
        private string condicion;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public int NumeroCamiseta
        {
            get { return numeroCamiseta; }
            set { numeroCamiseta = value; }
        }

        public string Condicion
        {
            get { return condicion; }
            set { condicion = value; }
        }

        public Jugador()
        {
        }

        public Jugador(string nombre, string posicion, int numeroCamiseta, string condicion)
        {
            this.nombre = nombre;
            this.posicion = posicion;
            this.numeroCamiseta = numeroCamiseta;
            this.condicion = condicion;
        }
    }
}
