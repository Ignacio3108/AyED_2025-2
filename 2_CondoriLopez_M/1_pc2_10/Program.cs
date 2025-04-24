using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escribe un programa que muestre por consola (con un print)
            los  números de 1 a 100 (ambos incluidos y con un salto
            de línea entre  cada impresión), sustituyendo los siguientes: 
            Múltiplos de 3 por la palabra "fizz". 
            Múltiplos de 5 por la palabra "buzz". 
            Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
            */

            for (int i = 1; i <= 100; i++)
            {
                string numero = i.ToString();

                if (i % 3 == 0)
                {
                    numero = "fizz";
                }
                else if (i % 5 == 0)
                {
                    numero = "buzz";
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    numero = "fizzbuzz";
                }
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
