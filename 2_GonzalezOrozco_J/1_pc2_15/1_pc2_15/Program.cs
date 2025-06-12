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
                        int rate = rand.Next(1, 100);
                        if (rate <= 30)
                        {
                            Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                            salud -= 15;
                        }
                        else
                        {
                            Console.WriteLine("Haz conseguido comida y la ingeriste. Hambre +20, Energía -15");
                            hambre += 20;
                            energia -= 15;
                        }

                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                            sigueVivo = false;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Dormiste. Energía +30, Hambre -10");
                        energia += 30;
                        hambre -= 10;

                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                            sigueVivo = false;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exploraste la isla. Energía -20, Hambre -15");
                        energia -= 30;
                        hambre -= 15;
                        rate = rand.Next(1, 100);
                        if(rate > 50)
                        {
                            Console.WriteLine("¡Encontraste una planta curativa! Salud +10.");
                            salud += 10;
                        }

                        if (salud <= 0 || hambre <= 0 || energia <= 0)
                        {
                            Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                            sigueVivo = false;
                        }
                        break;
                    case 4:
                        Console.Write("\nSalud: " + salud + ". Hambre: " + hambre + ". Energia: " + energia + ". dia: " + dia);
                        break;
                  
                }

              dia++;
            } while (dia < 8 && input != 5);
        }
    }
}
