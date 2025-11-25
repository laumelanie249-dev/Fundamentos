using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15_YORDAN
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            string continuar;
            do
            {
                Console.WriteLine("BIENVENIDOS AL REGISTRO DE PRODUCTOS");
                Console.WriteLine("1. Registrar");
                Console.WriteLine("2. Motrar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("0. Salir");

                Console.Write("\nIngrese opción: ");
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0: return;
                    case 1: registrar(); break;
                    case 2: mostrar();  break;
                    case 3: modificar();  break;
                }
                Console.Write("\nPara continuar ingrese(si): ");
                continuar = Console.ReadLine();
                Console.Clear();
            } while (continuar == "si");

        }
        static string[,] productos = new string[0, 3];
        static int cant = 0;

        static void redimensionar(int tamano)
        {
            string[,] nuevo = new string[tamano, 3];
            for (int i = 0; i < cant; i++)
            {
                for(int j = 0; j < productos.GetLength(1); j++)
                {
                    nuevo[i,j] = productos[i, j];
                }
            }
            productos = nuevo;
        }

        static void registrar()
        {
            redimensionar(cant + 1);

            Console.Write("\nNombre del producto: ");
            productos[cant,0]=Console.ReadLine();

            Console.Write("\nPrecio del producto: ");
            productos[cant, 1] = Console.ReadLine();

            Console.Write("\nStock del producto: ");
            productos[cant, 2] = Console.ReadLine();

            cant++;
            Console.WriteLine("\nProducto registrado correctamente");
        }

        static void mostrar()
        {
            for(int i=0; i<cant; i++)
            {
                Console.WriteLine("Producto " + (i + 1));
                Console.WriteLine("Nombre: " + productos[i,0]);
                Console.WriteLine("Precio: " + productos[i, 1]);
                Console.WriteLine("Stock: " + productos[i, 2]);
                Console.WriteLine();
            }
        }

        static void modificar()
        {
            Console.Write("Ingrese el número de producto: ");
            int indice=int.Parse(Console.ReadLine())-1;

            if (indice < 0 && indice >= cant) return;

            Console.WriteLine("\nIngrese nuevo nombre: ");
            productos[indice,0]=Console.ReadLine();

            Console.WriteLine("\nIngrese nuevo precio: ");
            productos[indice, 1] = Console.ReadLine();

            Console.WriteLine("\nIngrese nuevo stock: ");
            productos[indice, 2] = Console.ReadLine();

            Console.WriteLine("\nProducto modificado");
        }
    }
}
