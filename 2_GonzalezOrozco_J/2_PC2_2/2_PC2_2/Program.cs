using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC2_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresar cantidad de TPs: ");
            int cant_tps = int.Parse(Console.ReadLine());
            Console.Write("Ingresar cantidad de Examenes: ");
            int cant_exam = int.Parse(Console.ReadLine());
            int[] notas_tps = new int[cant_tps];
            int[] notas_exam = new int[cant_exam];
            int total_notas_tps = 0;
            int tps_aprob = 0;
            int total_notas_exam = 0;


            for (int i = 0; i < cant_tps; i++)
            {
                Console.Write("Ingresar nota del TP " + (i+1) + " : ");
                notas_tps[i] = int.Parse(Console.ReadLine());

                total_notas_tps += notas_tps[i];

                if (notas_tps[i] >= 6)
                {
                    tps_aprob++;
                }

            }
            int porcentaje_aprob = (tps_aprob / cant_tps) * 100;


            for (int i = 0; i < cant_exam; i++)
            {
                Console.Write("Ingresar nota del Examen " + (i+1) + " : ");
                notas_exam[i] = int.Parse(Console.ReadLine());

                total_notas_exam += notas_exam[i];
            }
            int promedio_exam = total_notas_exam / cant_exam;


            if (promedio_exam >= 6 && porcentaje_aprob >= 75)
            {
                Console.WriteLine("Vas a aprobar la materia!!");
            }
            else
            {
                Console.WriteLine("NO vas a aprobar la materia.");
            }
            // no use bool porque era redundante
            Console.ReadKey();

        }
    }
}
