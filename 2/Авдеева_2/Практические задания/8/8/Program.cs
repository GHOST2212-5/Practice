using System;

class ME
{
    static void Main()
    {
        Console.Write("Введите целое число (1 <= N <= 20): ");
        int N = Convert.ToInt32(Console.ReadLine());
        double r = 0.0;
        double p;

        for (int i = 1; i <= N; i++)
        {
            p = 1.0 + i * 0.1;
            if (i % 2 == 0)
            {
                r -= p;
            }
            else
            {
                r += p;
            }
        }

        Console.WriteLine("Результат: {0:F4}", r);
    }
}
