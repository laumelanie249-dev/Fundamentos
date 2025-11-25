using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15_YORDAN
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de matriz: ");
            int ta=int.Parse(Console.ReadLine());

            Console.WriteLine("\nMatriz: ");
            int[,] matriz = new int[ta, ta];
            Random rnd = new Random();

            for(int i = 0; i < ta; i++)
            {
                for(int j = 0; j < ta; j++)
                {
                    matriz[i,j] = rnd.Next(40,51);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz transpuestas: ");
            int[,] transpuesta=new int[ta, ta];
            for (int i = 0; i < ta; i++)
            {
                for (int j = 0; j < ta; j++)
                {
                    transpuesta[i, j] = matriz[j, i];
                    Console.Write(transpuesta[i,j] + " "); // se han cambiado el orden de la matriz para que se volteen como transpuestas
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
