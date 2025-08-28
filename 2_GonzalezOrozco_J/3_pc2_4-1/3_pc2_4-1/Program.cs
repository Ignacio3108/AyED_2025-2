using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_pc2_4_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 1 – Validación de llave (LITE)");
            bool ok = Level1.ValidateAccessKey("WD-700000")
                      && !Level1.ValidateAccessKey("WD-123123")
                      && !Level1.ValidateAccessKey("WX-000007")
                      && !Level1.ValidateAccessKey("WD-00007");
            if (ok) Console.WriteLine("✔ UNLOCK → Fragmento: CT");
            else Console.WriteLine("🔒 LOCKED");

            Console.ReadKey();
        }
    }

    static class Level1
    {
        // Debe devolver true solo si:
        // - Empieza por "WD-"
        // - Luego hay exactamente 6 dígitos
        // - La suma de esos 6 dígitos es múltiplo de 7
        public static bool ValidateAccessKey(string key)
        {
            // TODO: implementar
            int sum_6digit = 0;

            if (key.StartsWith("WD-"))
            {
                if (key.Length == 9)
                {
                    for (int i = 3; i < 9; i++)
                    {
                        sum_6digit += i;

                        if (char.IsDigit(key, i))
                        {}
                        else { return false; }
                    }

                    if(sum_6digit%7 == 0)
                    { return true; }
                    else { return false; }
                }
                else { return false; }
            }
            else { return false; }
        }
    }
}
