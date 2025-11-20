using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pc2_7
{
    class Program
    {
        static string[,] fichas = new string[20, 5];
        static int totalPersonajes = 0;

        static void Main(string[] args)
        {
            int opcionSeleccionada;
            bool funcionando = true;

            Console.WriteLine("Borderlands MVM");

            while (funcionando)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Crear personaje nuevo");
                Console.WriteLine("2. Buscar personaje por nombre");
                Console.WriteLine("3. Editar datos de un personaje");
                Console.WriteLine("4. Quitar un personaje");
                Console.WriteLine("5. Listar todos los personajes");
                Console.Write("Elija una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcionSeleccionada))
                {
                    switch (opcionSeleccionada)
                    {
                        case 1:
                            AgregarPersonaje();
                            break;
                        case 2:
                            BuscarPorNombre();
                            break;
                        case 3:
                            ModificarPersonaje();
                            break;
                        case 4:
                            EliminarPersonaje();
                            break;
                        case 5:
                            MostrarTodos();
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Vuelva a intentarlo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número por favor.");
                }
            }

            Console.WriteLine(AgregarPersonaje());
            BuscarPorNombre();
            Console.ReadKey();
        }

        static string AgregarPersonaje()
        {
            bool esHeroe;

            Console.Clear();
            Console.WriteLine("Ingrese el nombre del personaje nuevo:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la saga a la que pertenece:");
            string saga = Console.ReadLine();
            Console.WriteLine("Ingrese el valor de fuerza:");
            string fuerza = Console.ReadLine();
            Console.WriteLine("Ingrese el valor de defensa:");
            string defensa = Console.ReadLine();
            Console.WriteLine("Digite 's' si es héroe, si no digite 'n':");
            string respuesta = Console.ReadLine();

            if (respuesta == "s")
            {
                esHeroe = true;
            }
            else
            {
                esHeroe = false;
            }

            fichas[totalPersonajes, 0] = nombre;
            fichas[totalPersonajes, 1] = saga;
            fichas[totalPersonajes, 2] = fuerza;
            fichas[totalPersonajes, 3] = defensa;
            fichas[totalPersonajes, 4] = esHeroe.ToString();

            if (totalPersonajes > 20)
            {
                Console.WriteLine("No es posible crear más personajes.");
            }
            else
            {
                totalPersonajes++;
            }

            return "Personaje añadido";
        }

        static string BuscarPorNombre()
        {
            Console.WriteLine("Ingrese el nombre a buscar:");
            string nombreBuscado = Console.ReadLine();

            bool encontrado = false;

            for (int i = 0; i < totalPersonajes; i++)
            {
                if (fichas[i, 0] == nombreBuscado)
                {
                    Console.WriteLine($"Nombre: {fichas[i, 0]}");
                    Console.WriteLine($"Saga: {fichas[i, 1]}");
                    Console.WriteLine($"Fuerza: {fichas[i, 2]}");
                    Console.WriteLine($"Defensa: {fichas[i, 3]}");
                    Console.WriteLine($"¿Héroe?: {fichas[i, 4]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("No se encontró el personaje.");
            }

            return "Búsqueda completada";
        }

        static string ModificarPersonaje()
        {
            for (int i = 0; i < totalPersonajes; i++)
            {
                Console.Clear();
                Console.WriteLine($"Nombre: {fichas[i, 0]}");
                Console.WriteLine($"Saga: {fichas[i, 1]}");
                Console.WriteLine($"Fuerza: {fichas[i, 2]}");
                Console.WriteLine($"Defensa: {fichas[i, 3]}");
                Console.WriteLine($"¿Héroe?: {fichas[i, 4]}");
            }

            Console.WriteLine("\nEscriba el nombre del personaje cuyas características desea cambiar:");
            string elegido = Console.ReadLine();

            for (int j = 0; j < totalPersonajes; j++)
            {
                if (fichas[j, 0] == elegido)
                {
                    Console.WriteLine("Nuevo valor de fuerza:");
                    fichas[j, 2] = Console.ReadLine();
                    Console.WriteLine("Nuevo valor de defensa:");
                    fichas[j, 3] = Console.ReadLine();
                    Console.WriteLine("¿Es héroe? (s/n):");
                    fichas[j, 4] = Console.ReadLine();
                }
            }

            return "Personaje actualizado";
        }

        static string EliminarPersonaje()
        {
            Console.Clear();
            for (int i = 0; i < totalPersonajes; i++)
            {
                Console.WriteLine($"\nNombre: {fichas[i, 0]}");
                Console.WriteLine($"Saga: {fichas[i, 1]}");
                Console.WriteLine($"Fuerza: {fichas[i, 2]}");
                Console.WriteLine($"Defensa: {fichas[i, 3]}");
                Console.WriteLine($"¿Héroe?: {fichas[i, 4]}");
            }

            Console.WriteLine("\nIndique el nombre del personaje que desea borrar:");
            string borrar = Console.ReadLine();

            for (int k = 0; k < totalPersonajes; k++)
            {
                if (fichas[k, 0] == borrar)
                {
                    fichas[k, 0] = "";
                    fichas[k, 1] = "";
                    fichas[k, 2] = "";
                    fichas[k, 3] = "";
                    fichas[k, 4] = "";
                    totalPersonajes -= 1;
                }
            }

            return "Personaje eliminado";
        }

        static string MostrarTodos()
        {
            Console.Clear();
            for (int i = 0; i < totalPersonajes; i++)
            {
                Console.WriteLine($"\nNombre: {fichas[i, 0]}");
                Console.WriteLine($"Saga: {fichas[i, 1]}");
                Console.WriteLine($"Fuerza: {fichas[i, 2]}");
                Console.WriteLine($"Defensa: {fichas[i, 3]}");
                Console.WriteLine($"¿Héroe?: {fichas[i, 4]}");
            }
            return "Listado mostrado";
        }
    }


}
