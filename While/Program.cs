using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            while (number>=0 )
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}",number);
            Console.ReadKey();
        }
    }
}
