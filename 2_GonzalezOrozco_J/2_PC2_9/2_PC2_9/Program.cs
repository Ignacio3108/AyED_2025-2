using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //para q sea la matrix
            Console.WriteLine("Ingresar n: ");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar m: ");
            int columna = int.Parse(Console.ReadLine());
            Random rango = new Random();

            int[,] mimatriz = new int[fila, columna];

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    mimatriz[f, c] = rango.Next(1,100);
                }
            }

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    Console.Write(mimatriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
