using System;

class AN
{
    static void Main()
    {
        Console.WriteLine("Трёхзначные автоморфные числа:");

        for (int n = 100; n <= 999; n++)
        {
            int sq = n * n;
            string ns = n.ToString();
            string ss = sq.ToString();

            if (ss.EndsWith(ns))
            {
                Console.WriteLine(n);
            }
        }
    }
}
