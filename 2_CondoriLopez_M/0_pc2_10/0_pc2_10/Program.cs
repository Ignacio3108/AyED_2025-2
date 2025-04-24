using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // de grados centigrados a  Kelvin y Fahrenheit

            Console.Write("Ingrese la temperatura en celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double Kelvin = celsius + 273.15;
            double Fahrenheit = (celsius * 9/5) + 32;
            Console.WriteLine("kelvin: " + Kelvin + ". fahrenheit: " + Fahrenheit + ".");
            Console.ReadKey();

        }
    }
}
