using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMAMA11_Lenin
{
    internal class caso4
    {
        static void Main(string[] args)
        {
            //almacenar números de únicamente 4 dígitos
            Console.Write("Ingrese cantidad de sueldos enteros de 4 dígitos a generar: ");
            int can = int.Parse(Console.ReadLine());
            int[] sueldos = new int[can];
            Random rand = new Random();
            for (int i = 0; i < can; i++)
            {
                sueldos[i] = rand.Next(1000, 10000);
            }
            Console.WriteLine("Lista de sueldos generados");
            for (int i = 0; i < can; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
            int sueMi = sueldos[0];
            for (int i = 0; i < can; i++)
            {
                if (sueldos[i] < sueMi) sueMi = sueldos[i];
            }
            Console.WriteLine("El sueldo mínimo es: " + sueMi);
            Console.ReadKey();
        }
    }
}
