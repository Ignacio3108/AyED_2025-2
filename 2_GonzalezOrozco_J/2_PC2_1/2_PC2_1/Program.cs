using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresar cantidad de vueltas: ");
            int can_vueltas = int.Parse(Console.ReadLine());
            int[] tiempos = new int[can_vueltas];
            int total_carrera = 0;
            int promedio_vuelta = 0;
            int mejor_vuelta = 0;

            for (int i = 0; i < can_vueltas; i++)
            {
                Console.Write("Ingresar tiempo de vuelta " + (i+1) + " (en segundos): ");
                tiempos[i] = int.Parse(Console.ReadLine());

                total_carrera += tiempos[i];
                int vuelta_actual = tiempos[i];
                if (mejor_vuelta > vuelta_actual || mejor_vuelta == 0)
                {
                    mejor_vuelta = vuelta_actual;
                }
            }
            promedio_vuelta = total_carrera / can_vueltas;
            
            Console.WriteLine("Total de la carrera: " + total_carrera + " segundos.");
            Console.WriteLine("Promedio por vuelta: " + promedio_vuelta + " segundos.");
            Console.WriteLine("Mejor Vuelta: " + mejor_vuelta + " segundos.");
            Console.ReadKey();

        }
    }
}


