using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("escribe tu edad : ");
            int edad = int.Parse(Console.ReadLine());

            for (int contador = 1; contador < edad+1; contador++)
            {
                Console.WriteLine("AÑO "+contador);
            }

            Console.ReadKey();
        }
    }
}
