using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y = double.Parse(Console.ReadLine());

            double perimetro = 2 * x + 2 * y;
            double area = x * y;
            double diagonal = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        
            Console.WriteLine("Perimetro: " + perimetro + ". Area: " + area + ". Diagonal: " + diagonal +".");
            Console.ReadKey();

        }
    }
}
