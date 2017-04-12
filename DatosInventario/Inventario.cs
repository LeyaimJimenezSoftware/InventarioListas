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

        Producto productosAgragar = new Producto("","","","");
        int cont;
        int pos;
        Producto auxiliar;

        private int c = 0;

        string buscar = "";
        public void ingressarProducto(Producto p)
        {
            bool repite = false;
      
            for (int i = 0; i < c; i++)
            {
                if (productos[i].codigo == p.codigo)
                {
                    repite = true;
                    if(repite == true)
                    {
                        i = c-1;
                    }
                }

            }
            if (cont != 15 && repite == false)
            {
                productos[c] = p;
                c++;
            }
            
            cont++;
        }
        public string contador()
        {
            return c .ToString();
        }
        public void eliminarProducto(string codigo)
        {
            string aux;

          
            for (int i = 0; i < c; i++)
            {
                if (productos[i].codigo == codigo)
                {
                //    i = pos;
                //    aux = productos[i].ToString();
                //    c--;
                    for (int x = i; x < c; x++)
                    {
                        productos[x] = productos[x + 1];
                    }
                    productos[c] = null;
                    c--;
                   
                }
            }
           
        }

        public string buscarProducto(string codigo)
        {
            bool encontrado = false;
            for (int i = 0; i < c; i++)
            {
                if (productos[i].codigo == codigo)
                {
                    encontrado = true;
                    buscar = "Codigo:" + productos[i].codigo + " Nombre:" + productos[i].nombre + " Precio:" + productos[i].precio + " Cantidad:" + productos[i].cantidad;
                    if(encontrado == true)
                    {
                        i = c - 1;
                    }

                }
                else
                {
                    buscar = "No existe el producto";
                }
            

            }
            return buscar;

        }

        public void insertarProducto(Producto p , int pos)
        {
            if (pos < c)
            {
                if (productos[pos].codigo != null)
                {
                    for (int i = pos - 1; i < c; i++)
                    {
                        auxiliar = productos[i];
                        productos[i] = p;
                        p = auxiliar;
                        c++;
                    }


                }
                
            }
            else
            {
                productos[c] = p;
                c++;

            }

        }

        public override string ToString()
        {
            string str = " ";
            //foreach(Producto p in productos)
            //{
            //    str = p.ToString();

            //}

            for (int i = 0; i < c; i++)
            {
                str += "\n " +(i+1)+":"+productos[i].ToString()+"\n "; 
            }
            return str;
        }

    }

    }

