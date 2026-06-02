using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquinaexpendedora
{
    public class Venta
    {
        public string CodigoProducto { get; set; }

        public string NombreProducto { get; set; }

        public double Precio { get; set; }

        public DateTime Fecha { get; set; }

        public Venta(string codigo,
                     string nombre,
                     double precio)
        {
            CodigoProducto = codigo;

            NombreProducto = nombre;

            Precio = precio;

            Fecha = DateTime.Now;
        }
    }
}
