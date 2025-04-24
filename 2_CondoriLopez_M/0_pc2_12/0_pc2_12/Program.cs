using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribir letra 1: ");
            string letra1 = Console.ReadLine();
            Console.Write("Escribir letra 2: ");
            string letra2 = Console.ReadLine();
            Console.Write("Escribir letra 3: ");
            string letra3 = Console.ReadLine();
            Console.WriteLine(letra3 + letra2 + letra1);
            Console.ReadKey();       
        }
    }
}
