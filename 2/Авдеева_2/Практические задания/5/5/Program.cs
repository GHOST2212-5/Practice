using System;

class EI
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Число является четным.");
        }
        else
        {
            Console.WriteLine("Число нечетное.");
        }
    }
}
