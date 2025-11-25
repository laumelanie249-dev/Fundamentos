using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15_LENIN
{
    internal class Aleatorio
    {
        static void Main(string[] args)
        {
            /* Console.Write("Digite el orden de la matriz cuadrada para múmeros enteros aleatorios: ");
            int n=int.Parse(Console.ReadLine());
            Random ran=new Random();  //random permite trabajar con números aleatorios
            int[,]matriz=new int[n ,n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    matriz[i, j] = ran.Next(10, 100); //notas del 1-20, agregar un +1
                    Console.Write(matriz[i, j]+" ");
                }
                Console.WriteLine();
            } */
            Console.Write("Digite el orden de la matriz cuadrada para múmeros reales aleatorios: ");
            int n = int.Parse(Console.ReadLine());
            Random ran = new Random();  //random permite trabajar con números aleatorios
            double[,] matriz = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = Math.Round(ran.NextDouble(), 2); //Math.Round para redondear
                    //el "ran.NextDouble(),2" significa que el número serán reales de 0 pq está vacío el paréntesis y el 2 son los números a redondear. Ej:0.88( 2 números decimales)
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
