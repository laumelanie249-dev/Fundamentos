using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA11_YORDAN
{
    internal class ejer6
    {
        static void Main(string[] args)
        {
            string[] productos = new string[5];
            int registrados = 0;
            
            for(int i=0; registrados<5; i++)
            {
                Console.Write($"Ingrese producto {i + 1}: ");
                string pro = Console.ReadLine();

                bool duplicado = false;

                //verificando si ya fue registrado
                for(int j=0; j<registrados; j++)
                {
                    if (productos[j] == pro)
                    {
                        Console.WriteLine("El producto ya está registrado\n");
                        break;
                    }     
                    
                }
                //Si no es duplicado(falso), lo registramos
                if (duplicado == false)
                {
                    productos[registrados] = pro;
                    registrados++;
                }
            }
            Console.WriteLine("\nProducto registrado");
            foreach(string p in productos)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
