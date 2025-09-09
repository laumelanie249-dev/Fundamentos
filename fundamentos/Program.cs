using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey();
        }


        static void ejer1()
        {
            string nom, carrera;
            Console.Write("Ingrese su nombre: ");
            nom = Console.ReadLine();
            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();
            Console.WriteLine($"{nom}, bienvenida al curso de Fundamentos de Algoritmos de la carrera {carrera}");
        }


        static void ejer2()
        {
            Console.WriteLine("\"Melanie\"");
        }

        static void ejer3()
        {
            Console.Write("Ingrese número 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double divi = (double)num1 / (double)num2;
            Console.WriteLine("Suma: " + (num1 + num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicación: " + (num1 * num2));
            Console.WriteLine("División: " + divi);
            Console.ReadKey();
        }

        static void ejer4()
        {

        }

        static void ejer5()
        {

        }

        static void ejer6()
        {

        }
    }
}
