using System;

class FY
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        double y;

        if (x >= 10)
        {
            y = 4 + Math.Pow(x, 2) - Math.Exp(Math.Sqrt(x));
        }
        else
        {
            y = 3.4 - x + 0.1 * Math.Pow(x, 3);
        }

        Console.WriteLine("Значение y = {0}", Math.Round(y, 6));
    }
}
