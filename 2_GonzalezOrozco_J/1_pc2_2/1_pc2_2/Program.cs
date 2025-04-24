using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribir un programa que pida 
            al usuario dos números y
            muestre por pantalla su división.
            Si el divisor es cero el programa
            debe mostrar un error.
            */

            Console.Write("Ingresar el dividendo: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresar el divisor: ");
            double number2 = double.Parse(Console.ReadLine());

            double division = number1 / number2;

            if (number2 == 0)
            {
                Console.WriteLine("ERROR. DIVIDER 0 NOT SUPPORTED.");
            }
            else
            {
                Console.WriteLine(division);
            }
            Console.ReadKey();
        }
    }
}
