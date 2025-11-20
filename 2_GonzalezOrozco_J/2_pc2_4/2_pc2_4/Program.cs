using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int precio;
            int precio_max = int.MinValue;
            int precio_min = int.MaxValue;

            Console.Write("Cantidad de productos: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Precio producto N {i + 1}: ");
                precio = int.Parse(Console.ReadLine());

                if (precio > precio_max)
                {
                    precio_max = precio;
                }
                if (precio < precio_min)
                {
                    precio_min = precio;
                }
            }

            Console.WriteLine($"Precio Máximo: {precio_max}");
            Console.WriteLine($"Precio Mínimo: {precio_min}");
            Console.ReadKey();
        }
    }
}
