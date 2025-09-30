using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            string opcion;
            int summ = 0;
            do
            {
                Console.Clear();
                Console.Write("Ingrese número positivo: ");
                int numm = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numm; i++)
                    summ += i;

                Console.WriteLine("\nLa suma es: " + summ);

                Console.Write("¿Desea continuar(S/N)?: ");
                opcion = Console.ReadLine();

            } while (opcion != "N");
            Console.WriteLine("\nPrograma finalizado! ");
        }
    }
}
