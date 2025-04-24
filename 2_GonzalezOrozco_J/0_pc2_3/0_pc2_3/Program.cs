using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //tp3 - nombre y edad por input

            Console.Write("Cual es tu nombre??: ");
            string nombre = Console.ReadLine(); //pedimos input al user del nombre
            Console.Write("Y tu edad??: ");
            int edad = int.Parse(Console.ReadLine()); //parseamos edad tras pedir input de edad
            Console.WriteLine("Hola, " + nombre + "!! Tienes " + edad + " años!"); //concatenamos variables
            Console.ReadKey();
        }
    }
}
