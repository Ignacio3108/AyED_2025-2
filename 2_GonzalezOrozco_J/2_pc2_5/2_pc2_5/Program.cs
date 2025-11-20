using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int can_elementos;

            Console.Write("cantidad de elementos a analizar: ");
            can_elementos = int.Parse(Console.ReadLine());

            Console.Write("valor minimo de objetos para aparecer en el filtro: ");
            int v_min = int.Parse(Console.ReadLine());

            int[] elementos = new int[can_elementos];

            for (int i = 0; i < can_elementos; i++)
            {
                Console.Write("Valor objeto " + (i + 1) + ": ");
                elementos[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("objetos con valor mayor a " + v_min);

            for (int i = 0; i < can_elementos; i++)
            {
                if (elementos[i] > v_min)
                {
                    Console.WriteLine("objeto - pos. " + i + " valor " + elementos[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
