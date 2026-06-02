using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_Contactos
{
    public class Contact
    {
        // Getter y Setter (Encapsulamiento)
        public int IdContacto { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumContacto { get; set; }
        public string Direccion { get; set; }
        public string Genero { get; set; }
    }
}
