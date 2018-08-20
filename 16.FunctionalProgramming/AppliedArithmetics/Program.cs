using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' },
                                                 StringSplitOptions
                                                 .RemoveEmptyEntries)
                               .Select(int.Parse).ToArray();

            string commands;

            Func<int, int> adding = n => n + 1;
            Func<int, int> multiply = n => n * 2;
            Func<int, int> substract = n => n - 1;

            while ((commands = Console.ReadLine()) != "end")
            {
                if (commands == "add")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] = adding(input[i]);
                    }
                }
                if (commands == "multiply")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] = multiply(input[i]);
                    }
                }
                if (commands == "subtract")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] = substract(input[i]);
                    }
                }
                if (commands == "print")
                {
                    Console.WriteLine(string.Join(" ", input));
                }
            }
        }
    }
}
