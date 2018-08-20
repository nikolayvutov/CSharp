using System;
using System.Linq;
using System.Collections.Generic;

namespace SplitByWordCasing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                        .Split(new char[] {' ', ',', ':', ';',
                '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']'},
                                               StringSplitOptions
                                               .RemoveEmptyEntries).ToList();

            List<string> upperCase = new List<string>();
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();


            for (int i = 0; i < input.Count; i++)
            {
                if (input[i].All(char.IsLower))
                {
                    lowerCase.Add(input[i]);
                }
                else if (input[i].All(char.IsUpper))
                {
                    upperCase.Add(input[i]);
                }
                else
                {
                    mixedCase.Add(input[i]);
                }
            }
            Console.WriteLine($"Lower-case: {String.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {String.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", upperCase)}");
        }
    }
}
