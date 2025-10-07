using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA8_C_
{
    internal class ejer2
    {
        static void Main(string[] args)
        {
            string nom;
            Console.Write("Digite nombre: ");
            nom = Console.ReadLine();
            Console.Write("Digite edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Digite apellido: ");
            string ap = Console.ReadLine();
            Bienvenida(nom);
            Bienvenida(nom, edad);
            Bienvenida();
            Console.WriteLine(Bienvenida1());
            Console.WriteLine(Bienvenida1(nom, edad));
            Console.WriteLine(Apellido(ap));
            Console.ReadKey();
        }
        //Método void (vacío) sin parámetros
        static void Bienvenida()
        {
            Console.WriteLine("Bienvenido(a) al curso de FUNAL");
        }
        //Método void con parámetros
        static void Bienvenida(string nombre)
        {
            Console.WriteLine("Bienvenido(a): " + nombre);
        }
        static void Bienvenida(string nombre, int edad)
        {
            Console.WriteLine("Bienvenido(a): " + nombre);
            Console.WriteLine("Su edad es: " + edad);
        }
        //Método con retorno sin parámetros
        static string Bienvenida1()
        {
            return "Bienvenido(a) a la clase de Métodos";
        }
        //Método con retorno con parámetros
        static string Bienvenida1(string nom, int edad)
        {
            return "Bienvenido(a) otra vez " + nom + "\nSu edad es: " + edad;
        }
        //Método con retorno con parámetos
        static string Apellido(string ap)
        {
            return "Su apellido es: " + ap;
        }
    }
}
