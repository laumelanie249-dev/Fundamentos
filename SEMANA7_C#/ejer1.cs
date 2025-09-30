using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7_C_
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            int num, po = 0, ne = 0;
            do
            {
                Console.Write("Ingrese un # entero (negativo para finalizar): ");
                num = int.Parse(Console.ReadLine());

                if (num < 0) continue;
                if (num % 2 == 0) po++;
                else ne++;


            } while (num > 0);


            Console.WriteLine("\nCantidad de pares: " + po);
            Console.WriteLine("\nCantidad de impares: " + ne);
            Console.ReadKey();
        }
    }
}
