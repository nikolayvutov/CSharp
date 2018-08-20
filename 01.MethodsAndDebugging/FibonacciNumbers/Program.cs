using System;

namespace fibonacciNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(number));

        }
        static int Fibonacci(int number)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b;
        }
    }
}
