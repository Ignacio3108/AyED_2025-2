using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");

        string msg = "ctOS";
        string enc = Level4.CaesarPlusOne(msg);

        bool ok = enc == "duPT"; // c->d, t->u, O->P, S->T

        Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");

        Console.ReadKey();
    }
}

static class Level4
{
    public static string CaesarPlusOne(string s)
    {
        string result = "";

        foreach (char c in s)
        {
            // Letras minúsculas
            if (c >= 'a' && c <= 'y')
            {
                result += (char)(c + 1);
            }
            else if (c == 'z') 
            {
                result += 'a';
            }
            // Letras mayúsculas
            else if (c >= 'A' && c <= 'Y')
            {
                result += (char)(c + 1);
            }
            else if (c == 'Z') 
            {
                result += 'A';
            }
          
            else
            {
                result += c;
            }
        }

        return result;
    }
}
