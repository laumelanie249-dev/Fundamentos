using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMAMA11_Lenin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0.0;
            int canP = 0, canI = 0;
            Console.Write("Digite cantidad de edades a ingresar: ");
            int can = int.Parse(Console.ReadLine());
            int[] edades = new int[can]; //vector para almacenar n edades
            for (int i = 0; i < can; i++)
            {
                edades[i] = int.Parse(Console.ReadLine());
                suma = suma + edades[i]; //suma+=edades[i]
                if (edades[i] % 2 == 0) canP++;
                else canI++;
            }
            //visualizar las edades ingresadas
            Console.WriteLine("Edades ingresadas");
            for (int i = 0; i < can; i++)
            {
                Console.WriteLine(edades[i]);
            }
            for (int i = 0; i < can; i++)
            {
                Console.WriteLine("La edad en posición " + i + " es: " + edades[i]);
            }

            Console.Write("\nLa suma de edades es: " + suma);

            Console.WriteLine("\nEl promedio de edades es: " + (suma * 1.0 / can));

            Console.WriteLine("\nHay " + canP + " edades pares");
            Console.WriteLine("\nHay " + canI + " edades impares");

            Console.ReadKey();
        }
    }
}
