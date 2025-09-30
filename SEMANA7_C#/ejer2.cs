using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA7_C_
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            int numm;
            Console.WriteLine("*********************************************");
            Console.WriteLine("* BIENVENIDOS AL JUEGO DE ADIVINA EL NÚMERO *");
            Console.WriteLine("* INSTRUCCIONES:                            *");
            Console.WriteLine("* 1. Tienes 3 intentos                      *");
            Console.WriteLine("* 2. Cada fallo ud. tendrá una pista        * ");
            Console.WriteLine("*********************************************");

            int intentos = 3;
            Random rnd = new Random();
            int secreto = rnd.Next(1, 21);

            do
            {
                Console.Write("Ingrese el número a adivinar: ");
                numm = int.Parse(Console.ReadLine());

                if (secreto == numm)
                {
                    Console.WriteLine("\nCorrecto! Adivinaste el número");
                    return;
                }
                else
                {
                    intentos--;
                    if (numm < secreto)
                    {
                        Console.WriteLine("Pista: El número es mayor");
                    }
                    else
                    {
                        Console.WriteLine("Pista: El número es menor");
                    }
                }
                

            } while (intentos > 0);
            Console.WriteLine($"\nNo lograste adivinar el número {secreto}!");
            Console.ReadKey();

        }
    }
}
