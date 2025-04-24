    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresar Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad < 18)
            {
                Console.WriteLine("Todavia eres menor de edad.");
            }
            else
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            Console.ReadKey();
        }
    }
}
