using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nivel 3 – Firewalls adyacentes (LITE)");

        int[,] g =
        {
            {0,1,0},
            {1,0,1},
            {0,1,0}
        };

        bool ok = Level3.CountAdjacent(g, 1, 1) == 4
               && Level3.CountAdjacent(g, 0, 0) == 2;

        Console.WriteLine(ok ? "✔ UNLOCK → Fragmento: -OK" : "🔒 LOCKED");

        Console.ReadKey();
    }
}

static class Level3
{
    public static int CountAdjacent(int[,] grid, int row, int col)
    {
        int count = 0;
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);


        int[] dRow = { -1, 1, 0, 0 };
        int[] dCol = { 0, 0, -1, 1 };

        for (int i = 0; i < 4; i++)
        {
            int r = row + dRow[i];
            int c = col + dCol[i];
            if (r >= 0 && r < rows && c >= 0 && c < cols)
            {
                if (grid[r, c] == 1)
                    count++;
            }
        }

        return count;
    }
}
