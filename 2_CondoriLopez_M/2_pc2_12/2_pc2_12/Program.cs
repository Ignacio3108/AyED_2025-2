using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random azar = new Random();
            azar.Next(1, 100);


            Console.Write("ingresar tamaño matriz:");
            n = int.Parse(Console.ReadLine());
            int[,] matriz1 = new int[n, n];

            Console.WriteLine("Matriz N1:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz1[i, j] = azar.Next(1, 101);
                    Console.Write(matriz1[i, j] + "\t");
                }

                Console.WriteLine();
            }

            int[] diag = new int[n];

            Console.WriteLine("Diagonal de la matriz:");
            for (int i = 0; i < n; i++)
            {
                diag[i] = matriz1[i, i];
                Console.Write(diag[i] + "\t");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
