using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionElegida;
            bool ejecutando = true;
            string[,] registros = new string[75, 5];
            int total = 0;

            while (ejecutando)
            {
                Console.WriteLine("=== Menú - Centro de Investigación de Pochimons ===");
                Console.WriteLine("1) Añadir nuevo Pochimon");
                Console.WriteLine("2) Asignar investigador a un Pochimon");
                Console.WriteLine("3) Incrementar nivel de un Pochimon");
                Console.WriteLine("4) Marcar Pochimon como investigado");
                Console.WriteLine("5) Ver todos los Pochimons");
                Console.WriteLine("6) Buscar Pochimons por tipo");
                Console.WriteLine("7) Ver Pochimons por investigador");
                Console.WriteLine("8) Mostrar Pochimons Picados (>30)");
                Console.WriteLine("9) Salir");
                Console.WriteLine("Ingrese la opción deseada:");

                if (int.TryParse(Console.ReadLine(), out opcionElegida))
                {
                    switch (opcionElegida)
                    {
                        case 1:
                            Console.Clear();
                            if (total < 75)
                            {
                                Console.Write("Nombre del Pochimon: ");
                                registros[total, 0] = Console.ReadLine();
                                Console.Write("Tipo (A/F/P): ");
                                registros[total, 1] = Console.ReadLine().ToUpper();
                                Console.Write("Nivel inicial: ");
                                registros[total, 2] = Console.ReadLine();
                                registros[total, 3] = "0";
                                registros[total, 4] = "0";
                                total++;
                                Console.WriteLine("\nPochimon agregado correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("No se pueden registrar más Pochimons, capacidad completa.");
                            }
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Pochimons sin investigación:");
                            Console.WriteLine("ID\tNombre\tTipo\tNivel");
                            for (int i = 0; i < total; i++)
                            {
                                if (registros[i, 3] == "0")
                                {
                                    Console.WriteLine($"{i + 1}\t{registros[i, 0]}\t{registros[i, 1]}\t{registros[i, 2]}");
                                }
                            }
                            Console.Write("\nIndique el ID del Pochimon para asignar: ");
                            int idxAsignar = int.Parse(Console.ReadLine()) - 1;
                            if (registros[idxAsignar, 3] == "0")
                            {
                                Console.Write("Número del investigador: ");
                                string investigador = Console.ReadLine();
                                registros[idxAsignar, 4] = investigador;
                                registros[idxAsignar, 3] = "1";
                                Console.WriteLine("Asignación realizada con éxito.");
                            }
                            else
                            {
                                Console.WriteLine("Ese Pochimon ya está (o estuvo) en investigación.\n");
                            }
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("Listado de Pochimons:");
                            Console.WriteLine("ID\tNombre\tNivel");
                            for (int i = 0; i < total; i++)
                            {
                                Console.WriteLine($"{i + 1}\t{registros[i, 0]}\t{registros[i, 2]}");
                            }
                            Console.Write("\nID del Pochimon a actualizar: ");
                            int idxActualizar = int.Parse(Console.ReadLine()) - 1;
                            Random rnd = new Random();
                            int subida = rnd.Next(1, 4);
                            int nivelViejo = int.Parse(registros[idxActualizar, 2]);
                            int nivelNuevo = nivelViejo + subida;
                            registros[idxActualizar, 2] = nivelNuevo.ToString();
                            Console.WriteLine($"\n¡Nivel modificado! {registros[idxActualizar, 0]} pasó de {nivelViejo} a {nivelNuevo}");
                            break;

                        case 4:
                            Console.Clear();
                            Console.WriteLine("Pochimons actualmente en investigación:");
                            Console.WriteLine("ID\tNombre\tTipo\tNivel\tInvestigador");
                            bool alguno = false;
                            for (int i = 0; i < total; i++)
                            {
                                if (registros[i, 3] == "1")
                                {
                                    Console.WriteLine($"{i + 1}\t{registros[i, 0]}\t{registros[i, 1]}\t{registros[i, 2]}\t{registros[i, 4]}");
                                    alguno = true;
                                }
                            }
                            if (alguno)
                            {
                                Console.Write("\nID del Pochimon para marcar como investigado: ");
                                int idxInvestigado = int.Parse(Console.ReadLine()) - 1;
                                if (registros[idxInvestigado, 3] == "1")
                                {
                                    registros[idxInvestigado, 3] = "2";
                                    Console.WriteLine("Estado cambiado: ahora investigado.");
                                }
                                else
                                {
                                    Console.WriteLine("El Pochimon seleccionado no está en investigación.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No hay Pochimons en investigación en este momento.");
                            }
                            break;

                        case 5:
                            Console.Clear();
                            if (total > 0)
                            {
                                Console.WriteLine("| ID | Nombre\tTipo\tNivel\tEstado\tInvestigador |");
                                Console.WriteLine("------------------------------------------------------");
                                for (int i = 0; i < total; i++)
                                {
                                    Console.WriteLine($"{i + 1}\t{registros[i, 0]}\t{registros[i, 1]}\t{registros[i, 2]}\t{registros[i, 3]}\t{registros[i, 4]}\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Aún no hay Pochimons registrados.");
                            }
                            break;

                        case 6:
                            Console.Clear();
                            Console.Write("Tipo a buscar (A/F/P): ");
                            string tipo = Console.ReadLine().ToUpper();
                            bool hallado = false;
                            Console.WriteLine($"\nPochimons del tipo {tipo}:");
                            Console.WriteLine("ID\tNombre\tTipo\tNivel\tEstado\tInvestigador");
                            for (int i = 0; i < total; i++)
                            {
                                if (registros[i, 1] == tipo)
                                {
                                    Console.WriteLine($"{i + 1}\t{registros[i, 0]}\t{registros[i, 1]}\t{registros[i, 2]}\t{registros[i, 3]}\t{registros[i, 4]}\n");
                                    hallado = true;
                                }
                            }
                            if (!hallado)
                            {
                                Console.WriteLine("No se hallaron Pochimons de ese tipo.\n");
                            }
                            break;

                        case 7:
                            Console.Clear();
                            Console.Write("Número del investigador: ");
                            string codigo = Console.ReadLine();
                            bool asignados = false;
                            Console.WriteLine($"\nPochimons del investigador {codigo}:");
                            Console.WriteLine("ID\tNombre\tTipo\tNivel\tEstado");
                            for (int i = 0; i < total; i++)
                            {
                                if (registros[i, 4] == codigo)
                                {
                                    Console.WriteLine($"{i + 1}\t{registros[i, 0]}\t{registros[i, 1]}\t{registros[i, 2]}\t{registros[i, 3]}");
                                    asignados = true;
                                }
                            }
                            if (!asignados)
                            {
                                Console.WriteLine("No hay Pochimons vinculados a ese investigador.");
                            }
                            break;

                        case 8:
                            Console.Clear();
                            Console.WriteLine("Pochimons Picados (nivel mayor a 30):");
                            Console.WriteLine("ID\tNombre\tTipo\tNivel");
                            bool existenPicados = false;
                            for (int i = 0; i < total; i++)
                            {
                                int nivel = int.Parse(registros[i, 2]);
                                if (nivel > 30)
                                {
                                    Console.WriteLine($"{i + 1}\t{registros[i, 0]}\t{registros[i, 1]}\t{registros[i, 2]}");
                                    existenPicados = true;
                                }
                            }
                            if (!existenPicados)
                            {
                                Console.WriteLine("No hay Pochimons que cumplan ese criterio.");
                            }
                            break;

                        case 9:
                            ejecutando = false;
                            Console.WriteLine("Cerrando la Pochidex...");
                            Console.WriteLine("Hasta luego.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Debe ingresar un número.");
                }

            }
            Console.ReadKey();

        }
    }
}
