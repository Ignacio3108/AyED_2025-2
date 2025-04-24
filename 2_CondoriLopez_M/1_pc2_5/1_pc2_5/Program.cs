using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* El usuario debe ingresar si tiene comida (sí o no)
  , un refugio (sí o no) y un bate (sí o no).
   El programa debe decir si sobrevive o no.
*/
namespace _0_pc2_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Tenes comida?: ");
            string comida = Console.ReadLine().ToUpper();

            Console.Write("Tenes refugio?: ");
            string refugio = Console.ReadLine().ToUpper();

            Console.Write("Tenes un bate?: ");
            string bate = Console.ReadLine().ToUpper();

            string aprobacion;

            if (comida == "SI" && refugio == "SI" && bate == "SI")
            {
                aprobacion = "Sobrevive.";
            }
            else
            {
                aprobacion = "NO Sobrevive.";
            }

            Console.WriteLine(aprobacion);
            Console.ReadKey();
        }
    }
}