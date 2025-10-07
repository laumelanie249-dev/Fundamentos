using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA8_C_
{
    internal class ejer1
    {
        static void Main(string[] args)
        {
            /*int op;
            do
            {
                Console.WriteLine("\nCasuística de 4 operaciones");
                Console.WriteLine("[1]Suma");
                Console.WriteLine("[2]Resta");
                Console.WriteLine("[3]Multiplicación");
                Console.WriteLine("[4]División");
                Console.WriteLine("[5]Salir");
                Console.Write("\nDigite # de opción: ");
                op = int.Parse(Console.ReadLine());

                double num1 = 0.0, num2 = 0.0;
                if(op>=1 && op <= 4)
                {
                    Console.Write("Digite 1er número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite 2do número: ");
                    num2 = double.Parse(Console.ReadLine());
                }
                switch (op)
                {
                    case 1:Suma(num1,num2);break;
                    case 2: Resta(num1, num2); break;
                    case 3: Multiplicación(num1, num2); break;
                    case 4: División(num1, num2); break;
                    case 5:Console.WriteLine("\nGracias por utilizar el sistema"); break;
                    default:Console.WriteLine("\nDigite la opción correta"); break;

                }
            } while (op != 5);
            Console.ReadKey();

        }
        static void Suma(double num1, double num2)
        {
            Console.Write("\nLa suma es: "+(num1 + num2));
        }

        static void Resta(double num1, double num2)
        {
            Console.Write("\nLa resta es: " + (num1 - num2));
        }

        static void Multiplicación(double num1, double num2)
        {
            Console.Write("\nLa multiplicación es: " + (num1 * num2));
        }

        static void División(double num1, double num2)
        {
            if (num2!=0)
            {
                Console.Write("\nLa división es: " + (num1 / num2));
            }
            else
            {
                Console.Write("\nResultado no existente");
            }
        } */
            int op;
            do
            {
                Console.WriteLine("\nCasuística de 4 operaciones");
                Console.WriteLine("[1]Suma");
                Console.WriteLine("[2]Resta");
                Console.WriteLine("[3]Multiplicación");
                Console.WriteLine("[4]División");
                Console.WriteLine("[5]Salir");
                Console.Write("\nDigite # de opción: ");
                op = int.Parse(Console.ReadLine());

                double num1 = 0.0, num2 = 0.0;
                if (op >= 1 && op <= 4)
                {
                    Console.Write("Digite 1er número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite 2do número: ");
                    num2 = double.Parse(Console.ReadLine());
                }
                switch (op)
                {
                    case 1: Suma(num1, num2); break;
                    case 2: Resta(num1, num2); break;
                    case 3: Multiplicación(num1, num2); break;
                    case 4: División(num1, num2); break;
                    case 5: Console.WriteLine("\nGracias por utilizar el sistema"); break;
                    default: Console.WriteLine("\nDigite la opción correta"); break;

                }
            } while (op != 5);
            Console.ReadKey();

        }
        static string Suma(double num1, double num2)
        {
            return "\nLa suma es: " + (num1 + num2);
        }

        static string Resta(double num1, double num2)
        {
            return "\nLa resta es: " + (num1 - num2);
        }

        static string Multiplicación(double num1, double num2)
        {
            return "\nLa multiplicación es: " + (num1 * num2);
        }

        static void División(double num1, double num2)
        {
            if (num2 != 0) Console.Write("\nLa división es: " + (num1 / num2));
            else Console.Write("\nResultado no existente");

        }
    
    }
}
