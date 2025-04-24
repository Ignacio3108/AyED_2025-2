using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_13
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
           Mostrar un mensaje de bienvenida al programa.
           Presentar un menú con al menos tres opciones numeradas.
           Permitir al usuario seleccionar una opción ingresando
           el número correspondiente.
           Realizar una 
           acción diferente para cada opción seleccionada.
           Repetir el proceso 
           hasta que el usuario elija una opción para salir del programa.
           */
                string eleccion = "";
                Console.WriteLine("Bienvenido!\nHay distintas opciones en el menu, que desea?");
                while (eleccion != "4")
                {
                    Console.Write("OPCION 1: Eclair con crema pastelera\nOPCION 2: Una Burga con queso y salsa Ignacio de la casa :)\nOPCION 3: Una ricaza torta de ricota con frutos rojos.\nOPCION 4: salir del programa.\n\nElige numero de opcion (1,2,3 o 4): ");
                    eleccion = Console.ReadLine();

                    switch (eleccion)
                    {
                        case "1":
                            Console.WriteLine("\n\nAca tenes tu eclair amigazo.\n\n");
                            break;
                        case "2":
                            Console.WriteLine("\n\nNos quedamos sin patys papa, disculpa.\n\n");
                            break;
                        case "3":
                            Console.WriteLine("\n\nIGNACIO se comio la torta de ricota, mal ahi.\n\n");
                            break;
                        default:
                            Console.WriteLine();
                            break;
                    }
                }
        }
    }
}
