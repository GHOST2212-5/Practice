using System;

class TF
{
    static void Main()
    {
        double A = Math.PI / 4;
        double B = Math.PI / 2;
        int M = 15; 

        double H = (B - A) / M;

        Console.WriteLine("Значения F(x) = 2 - sin(x):");
        Console.WriteLine("  X\t F(X)");
        Console.WriteLine("---------------");

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;
            double F = 2 - Math.Sin(x);
            Console.WriteLine("{0:F4}\t{1:F4}", x, F);
        }
    }
}
