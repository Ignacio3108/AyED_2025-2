using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar cantidad de invitados: ");
            int cant_invi = int.Parse(Console.ReadLine());
            int[] morfixinvi = new int[cant_invi];
            int todoelmorfi = 0;
            for (int i = 1; i <= cant_invi; i++)
            {
                Console.Write("Ingresar cantidad de comida que consume el invitado " + i + ": ");
                morfixinvi[i] = int.Parse(Console.ReadLine());
                todoelmorfi += morfixinvi[i];
            }

            int promedio = todoelmorfi / cant_invi;

            Console.WriteLine("Promedio de comida: " + promedio);
            Console.ReadLine();

        }
    }
}
