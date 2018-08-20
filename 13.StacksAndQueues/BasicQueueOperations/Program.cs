using System;
using System.Linq;
using System.Collections.Generic;

namespace basicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var examNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var n = Console.ReadLine().Split(' ').Select(int.Parse);

            var queue = new Queue<int>(n);

            var min = int.MaxValue;

            for (int i = 0; i < examNums[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (!queue.Contains(examNums[2]))
            {
                foreach (var num in queue)
                {
                    if (min > num)
                    {
                        min = num;
                    }
                }
                Console.WriteLine(min);
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
