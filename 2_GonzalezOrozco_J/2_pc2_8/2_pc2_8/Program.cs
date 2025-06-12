using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar tamaño de fila: ");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar tamaño de columna: ");
            int columna = int.Parse(Console.ReadLine());

            int[,] mimatriz = new int[fila, columna];

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < columna; c++)
                {
                    mimatriz[f, c] = 0;
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
