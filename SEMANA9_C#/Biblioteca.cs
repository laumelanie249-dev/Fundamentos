using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA9_C_
{
    internal class Biblioteca
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.WriteLine("\nCasuística con librería");
                Console.WriteLine("Calculadora básica para números múltiplos de 3");
                Console.WriteLine("[1] Suma");
                Console.WriteLine("[2] Resta");
                Console.WriteLine("[3] Multiplicación");
                Console.WriteLine("[4] División");
                Console.WriteLine("[5] Estado de los números");
                Console.WriteLine("[6] Salir");
                Console.Write("\nDigite # de opción: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            IngresoDatos();
                            if (Globales.a % 3 == 0 && Globales.b % 3 == 0)
                                Console.WriteLine("La suma es: " + cuatroOperaciones.Suma(Globales.a, Globales.b));
                            else
                                Console.WriteLine("Ingrese otra opción que sean múltiplos de 3");
                            break;
                        }
                    case 2:
                        {
                            IngresoDatos();
                            if (Globales.a % 3 == 0 && Globales.b % 3 == 0)
                                Console.WriteLine("La resta es: " + cuatroOperaciones.Resta(Globales.a, Globales.b));
                            else
                                Console.WriteLine("Ingrese otra opción que sean múltiplos de 3");
                            break;
                        }

                    case 3:
                        {
                            IngresoDatos();
                            if (Globales.a % 3 == 0 && Globales.b % 3 == 0)
                                Console.WriteLine("La multiplicación es: " + cuatroOperaciones.Multiplicación(Globales.a, Globales.b));
                            else
                                Console.WriteLine("Ingrese otra opción que sean múltiplos de 3");
                            break;
                        }
                    case 4:
                        {
                            IngresoDatos();
                            if (Globales.b == 0) Console.WriteLine("El denominador tiene que ser diferente a 0");
                            else
                                Console.WriteLine("La división es: " + cuatroOperaciones.División(Globales.a, Globales.b));
                            break;
                        }
                    case 5:
                        {
                            IngresoDatos();
                            Console.WriteLine("El estado es: " + cuatroOperaciones.Estado(Globales.a, Globales.b));
                            break;
                        }
                    case 6: Console.WriteLine("\nSaliste del software!!"); break;
                    default: Console.WriteLine("\nDigite opción correcta"); break;
                }
            } while (op != 6);
            Console.ReadKey();
        }
        public static class Globales
        {
            public static int a, b;
        }

        static void IngresoDatos()
        {
            Console.Write("Digite el 1er número: ");
            Globales.a = int.Parse(Console.ReadLine());
            Console.Write("Digite el 2do número: ");
            Globales.b = int.Parse(Console.ReadLine());
        }
    }
}
public class cuatroOperaciones
{
    public static int Suma(int n1, int n2)
    {
        return n1 + n2;

    }

    public static int Resta(int n1, int n2)
    {
        return n1 - n2;
    }

    public static int Multiplicación(int n1, int n2)
    {
        return n1 * n2;
    }

    public static double División(int n1, int n2)
    {
        return (n1 * 1.0 / n2);
    }

    public static string Estado(int n1, int n2)
    {
        if (n1 == n2) return "Los números son iguales";
        else if (n1 > n2) return "El mayor número es " + n1 + " y el menor número es " + n2;
        else return "El mayor número es " + n2 + " y el menor número es " + n1;
    }