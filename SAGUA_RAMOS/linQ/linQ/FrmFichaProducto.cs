using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linQ
{
    public partial class FrmFichaProducto : Form
    {
        Producto productoActual;

        public FrmFichaProducto()
        {
            InitializeComponent();

        }
        
        


        private void FrmFichaProducto_Load(object sender, EventArgs e)
        {
            if (productoActual != null)
            {
                txtCodigo.Text = productoActual.Codigo;
                txtNombre.Text = productoActual.Nombre;
                txtMarca.Text = productoActual.Marca;
                txtCategoria.Text = productoActual.Categoria;
            }
        }
    }
}
