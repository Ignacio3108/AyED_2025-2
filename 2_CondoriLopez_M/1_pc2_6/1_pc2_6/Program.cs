using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Pedir al usuario que ingrese la temperatura en grados Celsius. 
 * Según el valor, informar:
Si es menor o igual a 0 → "Se congela"
Si es mayor o igual a 100 → "Hierve"
Si está entre 1 y 99 → "Está en estado líquido"
*/
namespace _1_pc2_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Decime la temperatura en grados celsius: ");
            float temperatura = float.Parse(Console.ReadLine());
            string estado;

            if (temperatura <= 0)
            {
                estado = "Se congela";
            }
            else if (temperatura >= 100)
            {
                estado = "Hierve";
            }
            else
            {
                estado = "Esta en estado liquido";
            }

            Console.WriteLine(estado);

            Console.ReadKey();
        }
    }
}