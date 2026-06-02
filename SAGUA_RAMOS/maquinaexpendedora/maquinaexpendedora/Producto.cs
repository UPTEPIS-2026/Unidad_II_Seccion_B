using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquinaexpendedora
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Producto(string codigo, string nombre, double precio, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
    }
}
