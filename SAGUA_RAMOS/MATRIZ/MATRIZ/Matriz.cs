using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATRIZ
{
    public class Matriz
    {
        // Atributos privados (Encapsulamiento)
        private int filas;
        private int columnas;
        private int[,] datos;

        
        public int Filas { get { return filas; } }
        public int Columnas { get { return columnas; } }

        // Constructor
        public Matriz(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            datos = new int[filas, columnas];
        }

        // Indexador para acceder a los datos de forma segura (Encapsulamiento)
        public int this[int fila, int columna]
        {
            get { return datos[fila, columna]; }
            set { datos[fila, columna] = value; }
        }

        // Método para ingresar valores (versión para consola - mantenida por compatibilidad)
        public void IngresarValores()
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    
                }
            }
        }

        public void MostrarMatriz()
        {
            // Lógica de visualización
        }

        // Método para multiplicar matrices
        public Matriz Multiplicar(Matriz otra)
        {
      
            if (this.columnas != otra.filas)
            {
                throw new Exception("El número de columnas de la Matriz A debe ser igual al número de filas de la Matriz B.");
            }

            Matriz resultado = new Matriz(this.filas, otra.columnas);

            for (int i = 0; i < this.filas; i++)
            {
                for (int j = 0; j < otra.columnas; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < this.columnas; k++)
                    {
                        suma += this.datos[i, k] * otra.datos[k, j];
                    }
                    resultado.datos[i, j] = suma;
                }
            }

            return resultado;
        }
    }
}
