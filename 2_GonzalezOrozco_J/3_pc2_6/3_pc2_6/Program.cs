using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pc2_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("/// BALATRO \\\\n");

            string[] mano = random_hand();
            string tipo = type_hand(mano);
            int base_score = base_points(mano);
            double mult = multi(tipo);
            double total = base_score * mult;
            bool j_x2 = true;
            bool j_mas10 = true;

            total = Jokersapplicador(total, j_x2, j_mas10);
            MostrarResumen(mano, tipo, base_score, mult, total);
            Console.ReadKey();
        }

        static string[] random_hand()
        {
            Random rand = new Random();

            string[] palo = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] rango = { "H", "D", "C", "S" };

            string[] mano = new string[5];
            for (int i = 0; i < 5; i++)
            {
                mano[i] = palo[rand.Next(palo.Length)] + rango[rand.Next(rango.Length)];
            }
            return (mano);
        }
        static string type_hand(string[] mano)
        {
            int poker = 0;
            int trio = 0;
            int paresDistintos = 0;

            for (int i = 0; i < mano.Length; i++)
            {
                int iguales = 0;
                for (int j = 0; j < mano.Length; j++)
                {
                    if (i != j && mano[i][0] == mano[j][0])
                    {
                        iguales++;
                    }
                }

                if (iguales == 3)
                    poker++;
                else if (iguales == 2) trio++;
                else if (iguales == 1) paresDistintos++;
            }

            paresDistintos /= 2;

            if (poker > 0)
                return "Poker";
            if (trio > 0 && paresDistintos > 0)
                return "Full";
            if (trio > 0)
                return "Trio";
            if (paresDistintos > 0)
                return "Par";
            else
                return "Nada";
        }

        static int base_points(string[] mano)
        {
            int suma = 0;
            for (int i = 0; i < mano.Length; i++)
            {
                char r = mano[i][0];
                if (r == 'A')
                    suma += 14;
                else if (r == 'K') suma += 13;
                else if (r == 'Q') suma += 12;
                else if (r == 'J') suma += 11;
                else if (r == 'T') suma += 10;
                else suma += r - '0';
            }
            return suma;
        }

        static double multi(string tipo)
        {
            if (tipo == "Poker")
                return 4;
            if (tipo == "Full")
                return 3.5;
            if (tipo == "Trio")
                return 2.5;
            if (tipo == "Par")
                return 1.5;
            return 1;
        }

        static double Jokersapplicador(double puntaje, bool x2, bool mas10)
        {
            if (x2) puntaje *= 2;
            if (mas10) puntaje += 10;
            return puntaje;
        }

        static void MostrarResumen(string[] mano, string tipo, int basePts, double mult, double total)
        {
            Console.Write("MANOO: ");
            for (int i = 0; i < mano.Length; i++)
            {
                Console.Write(mano[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("TIPOO: " + tipo);
            Console.WriteLine("PUNTAJE BASE: " + basePts);
            Console.WriteLine("MULTIPLICADOR: " + mult);
            Console.WriteLine("TOTAL (CONTANDO JOKERS): " + total);
        }
    }

}
