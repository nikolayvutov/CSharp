using System;
using System.Collections.Generic;
using System.Linq;

namespace balancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }

            char[] opening = new [] { '{', '[', '(' };
            char[] closing = new [] { '}', ']', ')' };

            var stack = new Stack<char>();

            foreach (var el in input)
            {
                if (opening.Contains(el))
                {
                    stack.Push(el);
                }
                else if (closing.Contains(el))
                {
                    var lastElement = stack.Pop();
                    int openingIndex = Array.IndexOf(opening, lastElement);
                    int closingIndex = Array.IndexOf(closing, el);

                    if (openingIndex != closingIndex)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }

            }
            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else 
            {
                Console.WriteLine("YES");
            }
        }
    }
}
