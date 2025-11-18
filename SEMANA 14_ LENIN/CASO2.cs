using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_14__LENIN
{
    internal class CASO2
    {
        static void Main(string[] args)
        {
            Console.Write("Digite su nombre: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Su nombre tiene " + nom.Length + " caracteres");
            Console.WriteLine("Los 2 primeros caracteres de su nombre es: " + nom.Substring(0, 2)); //de la posición 0, cuenta 2 caracteres (0,2) como si fuera matrices
            Console.WriteLine("Los 2 últimos caracteres son: " + nom.Substring(nom.Length - 2, 2));
            //nom.Length = cantidad de caracteres del nombre
            // se agrega el "-2" para restarle 2 posiciones
            // se agrega el 2 para que cuente 2 caracteres desde la posición que está

            Console.WriteLine("El nombre en mayúscula es: " + nom.ToUpper());
            Console.WriteLine("El nombre en minúscula es: " + nom.ToLower());

            Console.Write("Digite sus datos: ");
            string[] datos = Console.ReadLine().Split(' '); //split registra los datos en caso que haya espacios
            // ej:Si se registra "Melanie" es solo un dato, si se registra "Melanie Lau" son 2 datos porque detecta un espacio entre ambas palabras
            if (datos.Length == 1)
                Console.WriteLine("Su primer nombre es: " + datos[0]);

            else if (datos.Length == 2)
            {
                Console.WriteLine("Su primer nombre es: " + datos[0]);
                Console.WriteLine("Su apellido paterno es " + datos[1]);
            }

            else
            {
                Console.WriteLine("Su primer nombre es: " + datos[0]);
                Console.WriteLine("Su apellido materno es " + datos[1]);
                Console.WriteLine("Su apellido paterno es " + datos[2]);
            }

            Console.ReadKey();
        }
    }
}
