
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArbolConsola
{
    class ArbolBinario
    {
        public NodoT Raiz { get; set; }

        public ArbolBinario()
        {
            this.Raiz = null;
        }

        public void InsertarNodo(NodoT nodo, int dato)
        {
            if (Raiz == null)
            {
                Raiz = new NodoT(dato);
            }
            else
            {
                if (dato < nodo.Valor)
                {
                    if (nodo.NodoIzquierdo == null)
                    {
                        NodoT nuevoNodo = new NodoT(dato);
                        nodo.NodoIzquierdo = nuevoNodo;
                       
                    }
                    else
                    {
                        InsertarNodo(nodo.NodoIzquierdo, dato);
                    }
                    
                }
                else if (dato > nodo.Valor)
                {
                    if (nodo.NodoDerecho == null)
                    {
                        NodoT nuevoNodo = new NodoT(dato);
                        nodo.NodoDerecho = nuevoNodo;
                        
                    }
                    else
                    {
                        InsertarNodo(nodo.NodoDerecho, dato);
                    }

                }
                else
                {
                    Console.WriteLine("Ese nodo ya se encuentra en el arbol");
                    Console.ReadKey();
                }
            }
        }

        public void RecorrerPreOrden(NodoT nodo )
        {
            if (nodo != null)
            {
                Console.Write(nodo.Valor + " ,");
                RecorrerPreOrden(nodo.NodoIzquierdo);
                RecorrerPreOrden(nodo.NodoDerecho);
            }
           
        }

        public void RecorrerEnOrden(NodoT nodo)
        {
            if (nodo != null)
            {
                RecorrerEnOrden(nodo.NodoIzquierdo);
                Console.Write(nodo.Valor + " ,");
                RecorrerEnOrden(nodo.NodoDerecho);
            }

        }

        public void RecorrerPostOrden(NodoT nodo)
        {
            if (nodo != null)
            {
                RecorrerPostOrden(nodo.NodoIzquierdo);
                RecorrerPostOrden(nodo.NodoDerecho);
                Console.Write(nodo.Valor + " ,");
                
            }

        }


    }
}
