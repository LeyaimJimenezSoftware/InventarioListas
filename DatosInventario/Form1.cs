using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosInventario
{
    public partial class Form1 : Form
    {
        Producto productos;
        Inventario InventarioDeProductos = new Inventario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgragar_Click(object sender, EventArgs e)
        {
            productos = new Producto(textBoxCodigo.Text, textBoxNombre.Text, textBoxPrecio.Text, textBoxCantidad.Text);
            

            productos.codigo = textBoxCodigo.Text;

            InventarioDeProductos.ingressarProducto(productos);
            

        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            textBoxDatos.Text = InventarioDeProductos.ToString(); 
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            productos = new Producto(textBoxEliminar.Text,"","","");
            InventarioDeProductos.eliminarProducto(textBoxEliminar.Text);
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Producto encontrar = InventarioDeProductos.buscarProducto(textBoxBuscar.Text);
            if (encontrar == null)
                textBoxDatos.Text = "NO ESTA";
            else
                textBoxDatos.Text = encontrar.ToString();

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            productos = new Producto(textBoxCodigo.Text, textBoxNombre.Text, textBoxPrecio.Text, textBoxCantidad.Text);
            InventarioDeProductos.insertarProducto(productos,Convert.ToInt32(textBoxInsertar.Text));
        }
    }
}
