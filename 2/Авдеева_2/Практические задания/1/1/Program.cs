using System;

class HW
{
    static void Main()
    {
        Console.Write("Введите массу в килограммах: ");
        int m = Convert.ToInt32(Console.ReadLine());
        int cents = m / 100;

        Console.WriteLine("Число полных центнеров - {0}", cents);
    }
}
