using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int candidatos_cantidad;

            Console.Write("cantidad de candidatos que realizaron el examen: ");
            candidatos_cantidad = int.Parse(Console.ReadLine());

            int[] score = new int[candidatos_cantidad];
            
            for (int i = 0; i < candidatos_cantidad; i++)
            {
                Console.Write($"puntaje del candidato {i + 1}: ");
                score[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("numero para filtrar los puntajes múltiplos (debe ser nro. entero): ");
            int filtroxd = int.Parse(Console.ReadLine());

            Array.Sort(score);
            Console.WriteLine("Puntajes ordenados de menor a mayor:");
            Console.WriteLine(string.Join(", ", score));

            for (int i = 0; i < candidatos_cantidad; i++)
            {
                if (score[i] % filtroxd == 0)
                {
                    Console.WriteLine("multiplo: " + score[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
