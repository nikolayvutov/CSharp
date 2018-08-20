using System;
using System.Collections.Generic;
using System.Linq;

namespace calculateSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            queue.Enqueue(n);
            var skip = 0;

            for (int i = 0; i < 49; i++)
            {
                switch(i % 3)
                {
                    case 0:
                        n = queue.ToArray().Skip(skip).Take(1).ToArray()[0];
                        queue.Enqueue(n + 1);
                        skip++;
                        break;
                    case 1:
                        queue.Enqueue((2 * n + 1));
                        break;
                    case 2:
                        queue.Enqueue(n + 2);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", queue));
        }
    }
}
