using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result2 = Add(ref number1,number2);
            Console.WriteLine(result2);

            static int Add(ref int number1, int number2)
            {
                number1 = 50;
                var result = number1 + number2;
                return result;          
            }
           
        }
    }
}
