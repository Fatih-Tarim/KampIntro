using System;

namespace MethodOverloading
{
    class Program
    {
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(4,4));
            Console.WriteLine(Multiply(4,4,8));
            
        }
    }
}
