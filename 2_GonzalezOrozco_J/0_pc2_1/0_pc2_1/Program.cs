using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tp1 - variable hello world (version optimizada)

            //formato para declarar variable: <tipo de dato> <nombre de variable>;
            //formato para instanciar variable: <nombre de variable> = <definicion>;

            //caso 1

            string variable1; //declaro variable
            variable1 = "Hola Mundo!"; //instancio variable
            Console.WriteLine(variable1); //imprimo variable
            Console.ReadKey(); //programa espera a cualquier input de teclado

            //caso 2

            string variable2 = "Hola Mundo!"; //declaro e instancio variable
            Console.WriteLine(variable2); //imprimo variable
            Console.ReadKey(); //programa espera a cualquier input de teclado
        }
    }
}
