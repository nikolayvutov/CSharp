using System;
using System.Linq;
using System.Collections.Generic;

namespace basicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var examNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var n = Console.ReadLine().Split(' ').Select(int.Parse);

            var stack = new Stack<int>(n);

            var min = int.MaxValue;

            for (int i = 0; i < examNums[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (!stack.Contains(examNums[2]))
            {
                foreach (var num in stack)
                {
                    if (min > num)
                    {
                        min = num;
                    }
                }
                Console.WriteLine(min);
            }
            else {
                Console.WriteLine("true");
            }
        }
    }
}
