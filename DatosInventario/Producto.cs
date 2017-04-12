using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosInventario
{
    class Producto
    {
        private string _codigo, _nombre, _precio, _cantidad;
       private Producto _siguiente;
        private Producto _inicio;

        public Producto(string codigo, string nombre, string precio, string cantidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        //public string producto()
        //{
        //    string a = "";
        //    return a;
    //}
         public string codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }
        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public string precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        public string cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }
        public Producto siguiente
        {
            get
            {
                return _siguiente;
            }
            set
            {
                _siguiente = value;
            }
        }
        public Producto inicio
        {
            get
            {
                return _inicio;
            }
            set
            {
                _inicio = value;
            }
        }

        public override string ToString()
        {
            string listaProductos = null;
            listaProductos = "Codigo: " + _codigo +" Nombre: " + _nombre + " Precio: " + _precio + " Cantidad: " + _cantidad + "\r\n" + "\r\n";
           
            return listaProductos;
        }













    }
}
