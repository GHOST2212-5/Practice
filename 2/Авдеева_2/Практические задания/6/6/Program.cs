using System;

class Animals
{
    static void Main()
    {
        Console.Write("Введите год: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int r = (y - 4) % 12; // цикл начинается с года Крысы (4-й год нашей эры).
        string an;

        switch (r)
        {
            case 0:
                an = "Крысы";
                break;
            case 1:
                an = "Быка";
                break;
            case 2:
                an = "Тигра";
                break;
            case 3:
                an = "Кролика";
                break;
            case 4:
                an = "Дракона";
                break;
            case 5:
                an = "Змеи";
                break;
            case 6:
                an = "Лошади";
                break;
            case 7:
                an = "Козы";
                break;
            case 8:
                an = "Обезьяны";
                break;
            case 9:
                an = "Петуха";
                break;
            case 10:
                an = "Собаки";
                break;
            case 11:
                an = "Свиньи";
                break;
            default:
                an = "вне цикла";
                break;
        }

        Console.WriteLine("{0}г. — это год {1}.", y, an);
    }
}
