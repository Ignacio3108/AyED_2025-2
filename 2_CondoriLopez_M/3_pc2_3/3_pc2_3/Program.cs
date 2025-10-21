using System;

namespace ConsoleApplication2
{
    class Program
    {
        static string[,] encargos = new string[25, 5];
        static int cantidadEncargos = 0;

        // menu
        static int MostrarMenu()
        {
            Console.WriteLine("--- Menú Principal ---");
            Console.WriteLine("1. Crear nuevo encargo");
            Console.WriteLine("2. Mostrar todos los encargos");
            Console.WriteLine("3. Asignar camión a encargo");
            Console.WriteLine("4. Mostrar todos los encargos asignados");
            Console.WriteLine("5. Promedio de ganancia por sede");
            Console.WriteLine("6. Mostrar el encargo con mayor distancia");
            Console.WriteLine("7. Filtrar encargos por código de camión");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                opcion = 0;
            }
            return opcion;
        }

        // Opción 1: Crear nuevo encargo 
        static void CrearEncargo()
        {
            if (cantidadEncargos < 25)
            {
                Console.Write("Ingrese el código del camión: ");
                encargos[cantidadEncargos, 0] = Console.ReadLine();

                Console.Write("Ingrese la distancia en KM: ");
                encargos[cantidadEncargos, 1] = Console.ReadLine();
                if (int.Parse(encargos[cantidadEncargos, 1]) < 0)
                {
                    Console.WriteLine("La distancia no puede ser negativa.");
                    Console.Write("Ingrese nuevamente la distancia (mayor a 0): ");
                    encargos[cantidadEncargos, 1] = Console.ReadLine();
                }

                Console.Write("Ingrese la sede (BS.AS. / BB / MDQ): ");
                encargos[cantidadEncargos, 2] = Console.ReadLine();

                Console.Write("Ingrese la ganancia esperada: ");
                encargos[cantidadEncargos, 3] = Console.ReadLine();

                encargos[cantidadEncargos, 4] = "0"; // sin asignar
                cantidadEncargos++;
                Console.WriteLine("\n¡Encargo registrado con éxito!");
            }
            else
            {
                Console.WriteLine("No hay más espacio para encargos.");
            }
        }

        // Opción 2: Mostrar todos los encargos
        static void MostrarEncargos()
        {
            Console.WriteLine("N°\tCodCamion\tDistancia\tSede\tGanancia\tAsignado");
            for (int i = 0; i < cantidadEncargos; i++)
            {
                Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t\t{encargos[i, 1]}\t\t{encargos[i, 2]}\t{encargos[i, 3]}\t\t{encargos[i, 4]}");
            }
        }

        // Opción 3: Asignar camión 
        static void AsignarCamion()
        {
            Console.WriteLine("Encargos no asignados:");
            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] == "0")
                {
                    Console.WriteLine($"{i + 1}. CodCamion: {encargos[i, 0]}, Distancia: {encargos[i, 1]}");
                }
            }
            Console.Write("Ingrese el número de encargo a asignar: ");
            int nencargo = int.Parse(Console.ReadLine()) - 1;

            if (encargos[nencargo, 4] == "0")
            {
                Console.Write("Ingrese el código del camión asignado: ");
                string codcamion = Console.ReadLine();
                encargos[nencargo, 4] = codcamion;
                Console.WriteLine("Encargo asignado con éxito.");
            }
            else
            {
                Console.WriteLine("Ese encargo ya está asignado.");
            }
        }

        // Opción 4: Mostrar asignados
        static void MostrarAsignados()
        {
            Console.WriteLine("Encargos asignados:");
            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] != "0")
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t{encargos[i, 1]}\t{encargos[i, 2]}\t{encargos[i, 3]}\t{encargos[i, 4]}");
                }
            }
        }

        // Opción 5: Promedio de ganancia por sede 
        static void PromedioGanancia()
        {
            double totalBS = 0, totalBB = 0, totalMDQ = 0;
            int cBS = 0, cBB = 0, cMDQ = 0;

            for (int i = 0; i < cantidadEncargos; i++)
            {
                double ganancia;
                if (!double.TryParse(encargos[i, 3], out ganancia)) continue;

                string sede = encargos[i, 2].ToUpper().Trim();
                switch (sede)
                {
                    case "BS.AS.":
                        totalBS += ganancia; cBS++; break;
                    case "BB":
                        totalBB += ganancia; cBB++; break;
                    case "MDQ":
                        totalMDQ += ganancia; cMDQ++; break;
                }
            }

            Console.WriteLine($"BS.AS.: {(cBS > 0 ? (totalBS / cBS).ToString("0.00") : "Sin datos")}");
            Console.WriteLine($"Bahía Blanca: {(cBB > 0 ? (totalBB / cBB).ToString("0.00") : "Sin datos")}");
            Console.WriteLine($"Mar del Plata: {(cMDQ > 0 ? (totalMDQ / cMDQ).ToString("0.00") : "Sin datos")}");
        }

        // --- Opción 6: Mayor distancia ---
        static void MayorDistancia()
        {
            if (cantidadEncargos == 0)
            {
                Console.WriteLine("No hay encargos.");
                return;
            }

            int max = int.Parse(encargos[0, 1]);
            for (int i = 1; i < cantidadEncargos; i++)
            {
                int dist = int.Parse(encargos[i, 1]);
                if (dist > max) max = dist;
            }

            Console.WriteLine($"Encargo(s) con mayor distancia ({max} km):");
            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (int.Parse(encargos[i, 1]) == max)
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t{encargos[i, 1]} km");
                }
            }
        }

        // Opción 7: Filtrar por código
        static void FiltrarPorCamion()
        {
            Console.Write("Ingrese el código de camión: ");
            string cod = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < cantidadEncargos; i++)
            {
                if (encargos[i, 4] == cod)
                {
                    Console.WriteLine($"{i + 1}\t{encargos[i, 0]}\t{encargos[i, 1]}\t{encargos[i, 2]}\t{encargos[i, 3]}\t{encargos[i, 4]}");
                    encontrado = true;
                }
            }

            if (!encontrado)
                Console.WriteLine("No hay encargos asignados a ese camión.");
        }

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                int opcion = MostrarMenu();
                Console.Clear();

                switch (opcion)
                {
                    case 1: CrearEncargo(); break;
                    case 2: MostrarEncargos(); break;
                    case 3: AsignarCamion(); break;
                    case 4: MostrarAsignados(); break;
                    case 5: PromedioGanancia(); break;
                    case 6: MayorDistancia(); break;
                    case 7: FiltrarPorCamion(); break;
                    case 8: continuar = false; Console.WriteLine("Adiós."); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }

                Console.WriteLine("\nPresione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
