using System;

class ROC
{
    static void Main()
    {
        int n = 80;

        while (n >= 10)
        {
            Console.WriteLine(n);
            n -= 2;
        }
    }
}

// Ctrl + K, Ctrl + U

//using System;

//class ROC
//{
//    static void Main()
//    {
//        int n = 80;

//        do
//        {
//            Console.WriteLine(n);
//            n -= 2;
//        } while (n >= 10);
//    }
//}

//using System;

//class ROC
//{
//    static void Main()
//    {
//        for (int n = 80; n >= 10; n -= 2) // инициализация, условие и шаг
//        {
//            Console.WriteLine(n);
//        }
//    }
//}
