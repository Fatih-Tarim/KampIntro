using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            switch (number)
            {
                case 10:
                    Console.WriteLine("sayı 10");
                    break;
                case 20:
                    Console.WriteLine("sayı 20");
                    break;
                default:
                    Console.WriteLine("Sayı 10 veya 20 değil");
                    break;

            }
        }
    }
}
