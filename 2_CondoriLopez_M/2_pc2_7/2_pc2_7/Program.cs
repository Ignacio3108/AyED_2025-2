using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_pc2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int siz_vector;
            int opcion;
            int numbuscar;
            bool loop = true;

            Console.Write("numero pos: ");
            siz_vector = int.Parse(Console.ReadLine());

            int[] vector = new int[siz_vector];
            Random random = new Random();

            while (loop)
            {
                Console.WriteLine("\n1 Imprimir todos las posiciones.");
                Console.WriteLine("2 Buscar numero.");
                Console.WriteLine("3 Ordenar de forma ascendente/descendente.");
                Console.WriteLine("4 Salir.");

                Console.Write("\n\nEliga una opcion: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            for (int i = 0; i < siz_vector; i++)
                            {
                                vector[i] = random.Next(1, 101);
                            }
                            Console.WriteLine(string.Join(", ", vector));

                            break;

                        case 2:
                            Console.Write("numero: ");
                            numbuscar = int.Parse(Console.ReadLine());
                            for (int i = 0; i < siz_vector; i++)
                            {
                                if (vector[i] == numbuscar)
                                {
                                    Console.WriteLine($"{numbuscar} encontrado en pos {i + 1}.");
                                    break;
                                }
                                else if (i == siz_vector - 1)
                                {
                                    Console.WriteLine($"{numbuscar} no encontrado.");
                                }
                            }

                            break;

                        case 3:
                            Console.Write("Ascendente (1) o Descendente (2): ");
                            int sort = int.Parse(Console.ReadLine());
                            if (sort == 1)
                            {
                                Array.Sort(vector);
                                Console.WriteLine("ascendente:");
                                Console.WriteLine(string.Join(", ", vector));
                            }
                            else if (sort == 2)
                            {
                                Array.Sort(vector);
                                Array.Reverse(vector);
                                Console.WriteLine("descendente:");
                                Console.WriteLine(string.Join(", ", vector));
                            }
                            else
                            {
                                Console.WriteLine("Orden inválido.");
                                break;
                            }
                            break;

                        case 4:
                            loop = false;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("error: input invalido.");
                }
            }
        }
    }
}
