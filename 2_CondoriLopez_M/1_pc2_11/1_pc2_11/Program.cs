using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe un Numero: ");
            int numero = int.Parse(Console.ReadLine());


            for (int contador = 1; contador <= numero; contador++)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine("numero par " + contador);
                }
            }

            Console.ReadKey();

        }
    }
}
