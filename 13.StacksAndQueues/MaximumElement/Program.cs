using System;
using System.Linq;
using System.Collections.Generic;

namespace maximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var maxStack = new Stack<int>();

            maxStack.Push(int.MinValue);

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split()
                                     .Select(int.Parse).ToArray();

                switch (command[0])
                {
                    case 1:
                        var element = command[1];
                        stack.Push(element);

                        if (element >= maxStack.Peek())
                        {
                            maxStack.Push(element);
                        }
                        break;
                    case 2:
                        var popedEl = stack.Pop();

                        if (maxStack.Peek() == popedEl)
                        {
                            maxStack.Pop();
                        }
                        break;
                    case 3:
                        int maxElement = maxStack.Peek();

                        Console.WriteLine(maxElement);
                        break;
                }

            }

        }
    }
}
