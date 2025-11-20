using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int parti;
            Console.Write("TORNEO GALAXY QUEST DE PIXEL DREAMS\n");

            Console.Write("Ingrese la cantidad de participantes: ");
            parti = int.Parse(Console.ReadLine());

            int[] score = new int[parti];

            for (int i = 0; i < parti; i++)
            {
                Console.Write("Score participante N" + (i + 1) +": ");
                score[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(score);
            Array.Reverse(score);

            Console.Write("\nPUNTAJES\n\n");
            for (int i = 0; i < score.Length; i++)
            {
                Console.WriteLine("Participante"+ (i + 1) +": "+ (score[i]) +" puntos");
            }
            Console.WriteLine($"el 1er lugar es para el Participante 1 con {score[0]} puntos");
            Console.WriteLine($"el ultimo lugar es para el Participante {score.Length} con {score[score.Length - 1]} puntos");

            Console.ReadKey();
        }
    }
}
