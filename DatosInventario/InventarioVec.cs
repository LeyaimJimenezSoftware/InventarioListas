using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosInventario
{
    class Inventario
    {
        Producto[] productos = new Producto[15];

        
       private Producto primeroInicio = new Producto("","","","");
        int cont;
        int pos;
        
        string buscar = "";
        public Inventario()
        {
            primeroInicio = null;
        }

        public void ingressarProducto(Producto nuevo)
        {
            if (primeroInicio == null)
            {
                primeroInicio = nuevo;
            }
            else
            {
                Producto temporal = primeroInicio;
                while (temporal.siguiente != null)
                {
                   temporal = temporal.siguiente;
                   
                }
                temporal.siguiente = nuevo;
            }

        }

        public void eliminarProducto(string codigo)
        {

            bool encontrado = false;
            Producto temporal = primeroInicio;
           

            while (temporal != null && encontrado != true)
            {
                if(temporal.codigo == codigo)
                {
                    primeroInicio = temporal.siguiente;
                    encontrado = true;
                }

                else if (temporal.siguiente.codigo == codigo)
                {


                    temporal.siguiente = temporal.siguiente.siguiente;

                    encontrado = true;
                }
                else
                {
                    temporal = temporal.siguiente;
                }
            }
          
        }

        public Producto buscarProducto(string codigo)
        {
            string str = "";
            Producto buscado = null;
            bool encontrado = false;
            Producto temporal = primeroInicio;


            while (temporal != null && encontrado !=true)
            {
                if (temporal.codigo == codigo)
                {
                   buscado = temporal;
                    encontrado = true;
                }
                else
                {
                    temporal = temporal.siguiente;
                }
            }
          



            return buscado;
        }

        public void insertarProducto(Producto p , int pos)
        {

            int cont = 0;
                Producto temporal = primeroInicio;
                while (temporal!= null)
                {
                    temporal = temporal.siguiente;
                if(cont == pos)
                {
                    Producto aux;
                    aux = temporal;
                    temporal = p;
                    temporal.siguiente = aux ;

                   
                }
                 cont++;

                }
                
        }

        public override string ToString()
        {
            string str = " ";

            Producto t = primeroInicio;

            while (t != null)
            {
               
                str += t.ToString();
                t = t.siguiente;

            }
            return str;



        }

    }

    }

