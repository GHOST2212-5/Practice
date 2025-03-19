using System;

class AO
{
    static void Main()
    {
        Console.Write("Введите A (1 <= A < B <= 100): ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите B (1 <= A < B <= 100): ");
        int B = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Числа между A и B:");
        for (int i = A; i <= B; i++)
        {
            Console.Write(i + " ");
        }

        int n = B - A + 1;
        Console.WriteLine("\nКоличество чисел: " + n);
    }
}
