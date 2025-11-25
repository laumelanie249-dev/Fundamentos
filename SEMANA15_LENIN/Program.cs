using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA15_LENIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir al usuario # de filas y columnas, y visualizarlo
            /* Console.Write("Digite # de filas: ");
            int fil=int.Parse(Console.ReadLine());
            Console.Write("Digite # de columnas: ");
            int col=int.Parse(Console.ReadLine());
            int[,]edades=new int[fil,col];
            for(int f = 0; f < fil; f++) //en matrices, primero se recorre las filas y luego las columnas
            {
                for(int c=0; c< col; c++)
                {
                    Console.Write("Digite el elemento en la posición [" + f + "," + c + "]: ");
                    edades[f, c]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz de edades: ");
            for(int f = 0;f < fil; f++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(edades[f, c] + " ");
                }
                Console.WriteLine(); 
            } */

            //Suma de matrices
            Console.Write("Digite # de filas de la matriz 1: ");
            int fil1 = int.Parse(Console.ReadLine());
            Console.Write("Digite # de columnas de la matriz 1: ");
            int col1 = int.Parse(Console.ReadLine());
            int[,] num1 = new int[fil1, col1];
            for (int f = 0; f < fil1; f++)
            {
                for (int c = 0; c < col1; c++)
                {
                    Console.Write("Digite el elemento en la posición [" + f + "," + c + "]: ");
                    num1[f, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.Write("Digite # de filas de la matriz 2: ");
            int fil2 = int.Parse(Console.ReadLine());
            Console.Write("Digite # de columnas de la matriz 2: ");
            int col2 = int.Parse(Console.ReadLine());
            int[,] num2 = new int[fil2, col2];
            for (int f = 0; f < fil2; f++)
            {
                for (int c = 0; c < col2; c++)
                {
                    Console.Write("Digite el elemento en la posición [" + f + "," + c + "]: ");
                    num2[f, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Suma de matrices: ");
            for (int f = 0; f < fil2; f++)
            {
                for (int c = 0; c < col2; c++)
                {
                    Console.Write(num1[f, c] + num2[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
