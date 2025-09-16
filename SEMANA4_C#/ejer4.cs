using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C_
{
    internal class ejer4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Cuadrado");
            Console.WriteLine("[2] Rectángulo");
            Console.WriteLine("[3] Triángulo");
            Console.WriteLine("[4] Círculo");
            Console.Write("\nIngrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:Console.Write("\nIngrese lado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nArea: " + (lado * lado));
                    break;
                case 2:
                    Console.Write("\nIngrese la base: ");
                    int bse = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese la altura: ");
                    int alt = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea: " + (bse * alt));
                    break;
                case 3:
                    Console.Write("\nIngrese la base: ");
                    int bse2 = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese la altura: ");
                    int alt2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea: " + ((bse2 * alt2)/2));
                    break;
                case 4:
                    Console.Write("\nIngrese la radio: ");
                    double radio = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nÁrea: " + Math.Round(Math.PI * (radio * radio)));
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break; 

            }
            Console.ReadKey();

        }
    }
}
