using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("NOMBRE: ");
            string nombre = Console.ReadLine();
            int salud = 100;
            int monedas = 50;
            int enemigosDerrotados = 0;
            bool tieneEspada = false;

            string eleccion = "";
            Console.WriteLine("\nBienvenido!\nElegi una de las opciones:\n");
            Console.WriteLine("OPCION 1: Mostrar estado del jugador\nOPCION 2: Encontrar espada mágica :)\nOPCION 3: Pelear contra un enemigo.\nOPCION 4: Comprar poción de vida (vale 20 monedas).\nOPCION 5: Salir del juego \n");
            while (eleccion != "5" && salud > 0)
            {
                Console.Write("Elige numero de opcion (1,2,3,4 o 5): ");
                eleccion = Console.ReadLine();

                switch (eleccion)
                {
                    case "1":
                        Console.Write("\nNombre: " + nombre + ". Salud: " + salud + ". Monedas: " + monedas + ". Enemigos derrotados: " + enemigosDerrotados + ". Espada: ");
                        if (tieneEspada == false)
                        {
                            Console.Write("Sin espada\n\n");
                        }
                        else
                        {
                            Console.Write("Con espada\n\n");
                        }
                        break;

                    case "2":
                        if (tieneEspada == false)
                        {
                            Console.WriteLine("\nencontraste la espada magica de owen.\n");
                            tieneEspada = true;
                        }
                        else
                        {
                            Console.WriteLine("\nya tenes la espada magica de owen.\n");
                        }
                        break;

                    case "3":
                        if (tieneEspada == true)
                        {
                            Console.WriteLine("\n¡Ganaste la batalla! Salud -10, Monedas +10.\n");
                            salud = salud - 10;
                            enemigosDerrotados = enemigosDerrotados + 1;
                            monedas = monedas + 10;
                        }
                        else
                        {
                            Console.WriteLine("\n¡Fue una pelea dura sin la espada magica de owen! Salud -30.\n");
                            salud = salud - 30;
                        }
                        break;

                    case "4":
                        if (monedas >= 20)
                        {
                            Console.WriteLine("\nUsaste una poción. +20 de salud.\n");
                            salud = salud + 20;
                            monedas = monedas - 20;
                        }
                        else
                        {
                            Console.WriteLine("\nNo tienes suficientes monedas.\n");
                        }
                        break;

                    default:
                        Console.WriteLine("\nOpción inválida. Elegí una opción del 1 al 5.\n");
                        break;
                }
            }

            Console.WriteLine("GAME OVER\n\n¡Gracias por jugar!\n");
            Console.ReadKey();
        }
    }
}
