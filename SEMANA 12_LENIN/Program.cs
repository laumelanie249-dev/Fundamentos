using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_12_LENIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplos con arreglos unidimensionales");
            Console.Write("Digite cantidad de edades: ");
            int can = int.Parse(Console.ReadLine());
            int[] edades = new int[can];
            for (int i = 0; i < can; i++)
            {
                Console.Write("Digite edad en la posición " + i + ": ");
                edades[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("\nLas edades ingresadas son: ");
            for (int i = 0; i < can; i++)
            {
                Console.WriteLine(edades[i]);
            }
            Console.WriteLine("\nEdades ordenadas en forma ascendente ");
            Console.WriteLine("por el método de la burbuja");
            // [0]50 - [1]20 - [2]40 -[3]30
            // [0]20 - [1]50 - [2]40 -[3]30
            for (int i = 0; i < can; i++)
            {
                int aux;
                for (int j = i + 1; j < can; j++) //j=1
                {
                    if (edades[i] > edades[j]) //50>20
                    {
                        aux = edades[i]; //50
                        edades[i] = edades[j]; //20
                        edades[j] = aux; //50
                    }
                }
            }
            for (int i = 0; i < can; i++)
            {
                Console.WriteLine(edades[i]);
            }

            Console.WriteLine("\nEdades ordenadas en forma descendente");
            for (int i = 0; i < can; i++)
            {
                int aux;
                for (int j = i + 1; j < can; j++)
                {
                    if (edades[i] < edades[j])
                    {
                        aux = edades[i];
                        edades[i] = edades[j];
                        edades[j] = aux;
                    }
                }
            }
            for (int i = 0; i < can; i++)
            {
                Console.WriteLine(edades[i]);
            }

            Console.WriteLine("Otra forma de los números en forma descendente");
            //otra forma, ya con los números en ascendente
            for (int i = can - 1; i >= 0; i--)
            {
                Console.WriteLine(edades[i]);
            }

            int[] edades1 = new int[can + 1]; //significa que se agregará un nuevo elemento a la matriz
            for (int i = 0; i < can; i++)
            {
                //edades: [0]40 - [2]30 - [3]20 - [4]10
                edades1[i] = edades[i];
                //edades: [0]40 - [2]30 - [3]20 - [4]10
            }
            Console.WriteLine("Lista de edades1: ");
            for (int i = can - 1; i >= 0; i--)
            {
                Console.WriteLine(edades1[i]);
            }
            Console.Write("Digite la posición donde se va a insertar la nueva edad: ");
            int posi = int.Parse(Console.ReadLine()); //posi=2
            Console.Write("Digite edad a insertar: ");
            int edad = int.Parse(Console.ReadLine()); //edad=50
            for (int i = can; i > posi; i--) //acá se hizo el espacio libre en la posición 2
            {
                edades1[i] = edades1[i - 1];
            }
            edades1[posi] = edad;

            Console.WriteLine("Lista con la nueva edad(ascendente)");
            for (int i = can; i >= 0; i--)
            {
                Console.WriteLine(edades1[i]);
            }

            Console.WriteLine("Lista con la nueva edad(descendente)");
            for (int i = 0; i <= can; i++)
            {
                Console.WriteLine(edades1[i]);
            }
            Console.ReadKey();
        }
    }
}
