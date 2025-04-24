using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un programa que almacene la cadena de 
            caracteres contraseña en una variable, 
            pregunte al usuario por la contraseña e 
            imprima por pantalla 
            si la contraseña introducida por el usuario 
            coincide con la guardada en la variable sin tener 
            en cuenta mayúsculas y minúsculas.
            */

            Console.Write("Cree una contraseña: ");
            string password = Console.ReadLine().ToUpper();
            Console.Write("ingresar contraseña: ");
            string password2 = Console.ReadLine().ToUpper();

            if (password == password2)
            {
                Console.WriteLine("Contraseña correcta. Puedes ingresar.");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta. Intente de nuevo.");
            }
            Console.ReadKey();
        }
    }
}
