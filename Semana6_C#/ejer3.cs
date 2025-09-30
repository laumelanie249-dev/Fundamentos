using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana6_C_
{
    internal class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al sistema de validación de contraseña");
            Console.Write("Genere una contraseña: ");
            string g = Console.ReadLine();

            Console.WriteLine("\n____________________________");
            Console.WriteLine("-    Valide su contraseña   -");
            Console.WriteLine("\n____________________________");

            
            int intentos = 3;
            while (intentos > 0)
            {
                Console.Write("Ingrese la contraseña: ");
                string i = Console.ReadLine();

                if (i == g)
                {
                    Console.WriteLine("Acceso concedido");
                    return;
                }
                else
                {
                    intentos--;
                    Console.WriteLine("\nContraseña incorrecta. Intentos restantes: " + intentos);
                }
            }
            Console.WriteLine("\nAcceso denegado. Cerrando programa");
            Console.ReadKey();
        }
    }
}
