using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_YORDAN
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            int[] num = { -2, 5, -1, 0, 8, -6, 3 };

            Console.WriteLine("Números: ");
            foreach (int i in num)
                Console.Write(i + " ");

            Console.Write("\nNúmeros reemplazados: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                    num[i] = 0;
                Console.Write(num[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
