using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribir un programa que pida al usuario un 
            número entero y muestre por pantalla si es par o impar.

            Y... ¿Si es 0?
            */

            Console.Write("Ingresar numero entero: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("ERROR: El numero es " + number + ". No es posible dividir 0 entre 2.");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("El numero " + number + " es par.");
            }
            else
            {
                Console.WriteLine("El numero " + number + " es impar.");
            }
            Console.ReadKey();
        }
    }
}
