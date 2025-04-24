using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Para poder cobrar la beca JuanPedro se debe cumplir con alguna de las siguientes condiciones... 
            1) ser mayor de 19 años y tener unos ingresos iguales o inferiores a $100.000 mensuales
            2) ser menor de 19 y no poseer ingresos mensuales
            3) tener 19 años y poseer ingresos hasta $50.000 mensuales
            Escribir un programa que pregunte al usuario su edad y 
            sus ingresos mensuales y muestre por pantalla si 
            el usuario puede cobrar o no.
            */

            Console.Write("Ingresar edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.Write("Ingresos mensuales (USD): ");
            float ingreso = float.Parse(Console.ReadLine());
            string aprobacion = "NO APTO.";

            if (edad > 19 && ingreso <= 100000)
            {
                aprobacion = "APTO.";
            }
            else if (edad < 19 && ingreso == 0)
            {
                aprobacion = "APTO.";
            }
            else if (edad == 19 && ingreso <= 50000)
            {
                aprobacion = "APTO.";
            }

            Console.WriteLine("Su condicion de cobro es " + aprobacion);
            Console.ReadKey();
        }
    }
}
