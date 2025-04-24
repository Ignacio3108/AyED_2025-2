using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("primer numero que vas a dividir: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("segundo numero con el que vas a dividir: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("el resto de la division es: ");
            int resultado = numero1 % numero2;

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
