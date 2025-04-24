using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_15
{
    class Program
    {
        static void Main(string[] args)
        {

            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 1;
            bool sigueVivo = true;
            Random rand = new Random();
            int input = 0;

            do
            {
              Console.Write("\nDía " + dia + " – ¿Qué querés hacer?\n\n1.Buscar comida\n2.Dormir\n3.Explorar la isla\n4.Ver estado del personaje\n5.Salir del juego\n\nSeleccionar opcion: ");
              input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }

              dia++;
            } while (dia < 8 && input != 5);
        }
    }
}
