using System;
using System.Collections.Generic;

namespace tafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            int count = 0;
            string input = Console.ReadLine();

            while (input != "end")
            {
                if (input == "green")
                {
                    var minimum = Math.Min(numberOfCars, queue.Count);
                    for (int i = 0; i < minimum; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
