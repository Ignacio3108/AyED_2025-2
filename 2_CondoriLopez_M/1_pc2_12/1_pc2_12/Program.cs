using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_12
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Escriba un programa que 
             pregunte una y otra vez 
             si desea terminar el programa,
             salvo si se contesta exactamente
             SI (en mayúsculas y sin tilde).
            */

            string si = "";
            while (si != "SI")
            {
                Console.Write("escriba SI para salir: ");
                si = Console.ReadLine();
            }
        }
    }
}
