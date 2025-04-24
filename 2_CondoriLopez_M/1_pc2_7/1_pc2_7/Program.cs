using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("escribe una palabra: ");
            string palabra = Console.ReadLine();

            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(palabra);
            }

            Console.ReadKey();
        }
    }
}
