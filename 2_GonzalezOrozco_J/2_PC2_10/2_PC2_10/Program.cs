using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //para q sea la matrix
            Console.Write("Ingresar n: ");
            int fila = int.Parse(Console.ReadLine());

            Random rango = new Random();
            int[,] matriz1 = new int[fila, fila];
            int[,] matriz2 = new int[fila, fila];
            int[,] matrizsuma = new int[fila, fila];


            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < fila; c++)
                {
                    matriz1[f, c] = rango.Next(1, 100);
                    matriz2[f, c] = rango.Next(1, 100);
                    matrizsuma[f, c] = matriz1[f, c]+ matriz2[f, c];
                }
            }

            for (int f = 0; f < fila; f++)
            {
                for (int c = 0; c < fila; c++)
                {
                    Console.WriteLine(matriz1[f, c] + " + " + matriz2[f,c] + " = " + matrizsuma[f, c]);
                }
            }
            Console.ReadKey();

        }
    }
}
