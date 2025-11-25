using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15_LENIN
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            //Matriz identidad(la diagonal izquierda es 1 y el resto es 0)
            Console.Write("Digite el orden de la matriz identidad: ");
            int n = int.Parse(Console.ReadLine());
            int[,] num = new int[n, n];
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (f == c)
                    {
                        num[f, c] = 1;
                    }
                    Console.Write(num[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
