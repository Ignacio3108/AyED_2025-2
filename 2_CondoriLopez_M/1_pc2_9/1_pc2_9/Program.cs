using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;

            while (edad <= 0)
            {
                Console.Write("Ingrese un numero positivo: ");
                edad = int.Parse(Console.ReadLine());
            }

            for (int contador = edad; contador >= 0; contador--)
            {
                Console.WriteLine(contador);
            }

            Console.ReadKey();
        }
    }
}
