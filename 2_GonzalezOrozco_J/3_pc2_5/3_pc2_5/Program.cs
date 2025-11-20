using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pc2_5
{
    class Program
    {
        static void Main()
        {
            int vida_hornet = 10;
            int maxima_vida_hornet = 10;
            int ataque_hornet = 3;
            int vida_enemigo = 12;

            Console.WriteLine("== Hollow Knight ==");

            while (vida_hornet > 0 && vida_enemigo > 0)
            {
                MostrarEstado(vida_hornet, vida_enemigo);

                Console.Write("\nAcción (atacar/curar/salir): ");
                string accion = Console.ReadLine();
                if (accion == "atacar")
                {
                    vida_enemigo = Atacar(ataque_hornet, vida_enemigo);
                }
                else if (accion == "curar")
                {
                    vida_hornet = Curar(vida_hornet, maxima_vida_hornet);
                }
                else if (accion == "salir")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Acción no válida.");


                }
                if (vida_enemigo > 0)
                {
                    vida_hornet -= 2;
                    Console.WriteLine("enemigo contraataca, -2hp!");
                }
            }
            Console.WriteLine("\n== cierre ==");
            if (vida_hornet <= 0) Console.WriteLine("Hornet cayo...");
            else if (vida_enemigo <= 0) Console.WriteLine("¡Hornet ganó!");
            else Console.WriteLine("pelea parada.");
        }

        static int Atacar(int ataque, int vida_enemigo)
        {
            vida_enemigo -= ataque;
            Console.WriteLine($"Hornet ataca, - " + ataque + " hp!");
            return vida_enemigo;
        }

        static int Curar(int vida_hornet, int maxima_vida_hornet)
        {
            int cura = 5;
            vida_hornet += cura;
            if (vida_hornet > maxima_vida_hornet) vida_hornet = maxima_vida_hornet;
            Console.WriteLine($"Hornet se cura, +" + cura + " hp!");
            return vida_hornet;
        }

        static void MostrarEstado(int vida_hornet, int vida_enemigo)
        {
            Console.WriteLine($"\nHornet HP: " + vida_hornet);
            Console.WriteLine($"Enemigo HP: " + vida_enemigo);
        }
    }
}
