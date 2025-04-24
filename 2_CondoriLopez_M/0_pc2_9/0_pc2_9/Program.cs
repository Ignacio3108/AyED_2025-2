using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese radio: ");
            double radio = double.Parse(Console.ReadLine());
            double superficie = 4 * 3.14 * Math.Pow(radio, 2);
            double volumen = 4 / 3 * 3.14 * Math.Pow(radio, 3);
            Console.WriteLine("Superficie: " + superficie + ". Volumen: " + volumen + ".");
            Console.ReadKey();

        }
    }
}
