using System;
using System.Text.RegularExpressions;

namespace MatchNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string input = Console.ReadLine();

            var numbers = Regex.Matches(input, pattern);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
