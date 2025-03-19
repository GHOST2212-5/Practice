using System;

class SCP
{
    static void Main()
    {
        Console.Write("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        bool SCP = x < 0 && y > 0;

        if (SCP)
        {
            Console.WriteLine("Точка лежит во второй координатной четверти.");
        }
        else
        {
            Console.WriteLine("Точка не лежит во второй координатной четверти.");
        }
    }
}
