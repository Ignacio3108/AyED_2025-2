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
            int cantinvitados;
            cantinvitados = int.Parse(Console.ReadLine());
            int[] invitados = new int[cantinvitados];

            for (int i = 0; i < cantinvitados; i++)
            {
                bool condicion = false;
                while (condicion == false)
                {
                    Console.Write("Ingrese la cantidad de comida para el invitado " + (i + 1) + " (puede ser entre 1 y 100): ");
                    int comida = int.Parse(Console.ReadLine());
                    if (comida >= 1 && comida<100)
                    {
                        condicion = true;
                    }
                    invitados[i] = comida;
                }

            }

            int promedio = 0;
            for (int i = 0; i < cantinvitados; i++)
            {
                promedio += invitados[i];
            }

            Console.WriteLine("El promedio por invitado es: " + promedio / cantinvitados);
            Console.ReadKey();
        }
    }
}
