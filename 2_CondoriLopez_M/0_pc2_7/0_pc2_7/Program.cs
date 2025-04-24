using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dame un numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Dame otro numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 / numero2;

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
