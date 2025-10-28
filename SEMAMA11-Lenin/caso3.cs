using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMAMA11_Lenin
{
    internal class caso3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite # de notas aleatorias reales a generar: ");
            int can = int.Parse(Console.ReadLine());
            double[] notas = new double[can];
            Random rand = new Random();
            for (int i = 0; i < can; i++)
            {
                //notas[i]=rand.NextDouble();
                notas[i] = Math.Round(rand.NextDouble() * (0 - 20) + 20, 2);
            }
            Console.WriteLine("Notas reales generadas ");
            for (int i = 0; i < can; i++)
            {
                Console.WriteLine(notas[i]);
            }
            Console.ReadKey();
        }
    }
}
