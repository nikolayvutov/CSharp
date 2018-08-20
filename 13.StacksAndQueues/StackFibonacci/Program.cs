using System;
using System.Collections.Generic;


namespace stackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }

        private static long GetFibonacci(long n)
        {
            var stack = new Stack<long>();
            stack.Push(0);
            stack.Push(1);

            long first = 0;
            long second = 1;

            for (int i = 0; i < n - 1; i++)
            {
                long next = first + second;

                stack.Push(next);

                first = second;
                second = next;

            }

            return stack.Pop();
        }
    }
}
