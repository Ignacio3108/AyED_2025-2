using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("cantidad de estudiantes: ");
            int fila = int.Parse(Console.ReadLine());

            string[,] alumnos = new string[fila, 3];

            for (int i = 0; i < fila; i++)
            {
                Console.WriteLine("\nEstudiante "+ (i+1));
                Console.Write("Nombre: ");
                alumnos[i, 0] = Console.ReadLine();
                Console.Write("Edad: ");
                alumnos[i, 1] = Console.ReadLine();
                Console.Write("Nota: ");
                alumnos[i, 2] = Console.ReadLine();
            }

            Console.WriteLine("\nListado alumnos:");
            Console.WriteLine("N°\tNombre\tEdad\tNota");

            for (int i = 0; i < fila; i++)
            {
                Console.WriteLine($"{i + 1}\t{alumnos[i, 0]}\t{alumnos[i, 1]}\t{alumnos[i, 2]}");
            }

            Console.ReadKey();

        }
    }
}
