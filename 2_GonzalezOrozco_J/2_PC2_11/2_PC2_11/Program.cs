using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar tamaño n: ");
            int fila = int.Parse(Console.ReadLine());
            Random rand = new Random();

            int[,] mimatriz = new int[fila, fila];

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < fila; c++)
                {
                    mimatriz[f, c] = rand.Next(1,100);
                }
            }

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < fila; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int f = fila; f > 0; f--)
            {
                for (int c = fila; c > 0; c--)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
