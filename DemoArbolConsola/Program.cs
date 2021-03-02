using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArbolConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbolito = new ArbolBinario();
            while (true)
            {
                Console.WriteLine("1-Insertar nodo");
                Console.WriteLine("2-Buscar");
                Console.WriteLine("3-Recorrido en preorden");
                Console.WriteLine("4-Recorrido en orden");
                Console.WriteLine("5-Recorrido en postorden");
                Console.WriteLine("Selecciona una opcion");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el valor: ");
                        int valor = int.Parse(Console.ReadLine());
                        arbolito.InsertarNodo(arbolito.Raiz, valor);
                        break;
                    case 3:
                        Console.WriteLine("RECORRIDO EN PRE-ORDEN");
                        arbolito.RecorrerPreOrden(arbolito.Raiz);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("RECORRIDO EN ORDEN");
                        arbolito.RecorrerEnOrden(arbolito.Raiz);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("RECORRIDO EN POST-ORDEN");
                        arbolito.RecorrerPostOrden(arbolito.Raiz);
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }

        }
    }
}
