using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMAMA11_Lenin
{
    internal class caso2
    {
        static void Main(string[] args)
        {
            int notasMi = 0, notasMa = 0;
            Console.WriteLine("Digite # de notas aleatorias a generar: ");
            int can = int.Parse(Console.ReadLine());
            int[] notas = new int[can];
            Random rand = new Random();
            for (int i = 0; i < can; i++)
            {
                //notas[i]=rand.Next(min.max+1)
                notas[i] = rand.Next(0, 21); //enteros
                if (notas[i] == 0) notasMi++;
                if (notas[i] == 20) notasMa++;
            }
            Console.WriteLine("Lista de notas creadas en forma aleatoria");
            for (int i = 0; i < can; i++)
            {
                if (notas[i] == 0) Console.WriteLine(notas[i] + " = nota mínima");
                else if (notas[i] == 20) Console.WriteLine(notas[i] + " = nota máxima");
                else Console.WriteLine(notas[i]);
            }
            Console.WriteLine("Hay " + notasMi + " con valor 0");
            Console.WriteLine("Hay " + notasMa + " con valor 20");

            Console.ReadKey();
        }
    }
}
