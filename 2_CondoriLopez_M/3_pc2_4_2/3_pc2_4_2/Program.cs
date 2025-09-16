using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 2 – Ping Check (LITE)");

        int[] p = { 13, 250, -5, 40, 40, 40, 100, 205, 100 };
        int s = Level2.SumValidEveryThird(p);

        bool ok = s == (13 + 40 + 100); // 153
        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -ACCESS" : "🔒 LOCKED");
        Console.ReadKey();
    }
}

static class Level2
{
 
    public static int SumValidEveryThird(int[] p)
    {
        int suma = 0;
        for (int i = 0; i < p.Length; i++)
        {
            if (i % 3 == 0 && p[i] >= 0 && p[i] <= 200)
            {
                suma += p[i];
            }
        }
        return suma;
    }
}