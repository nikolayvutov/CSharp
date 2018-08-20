using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var pattern = @"([^0-9]+)(\d+)";
            var input = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                string word = m.Groups[1].Value.ToUpper();
                int count = int.Parse(m.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            int unique = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {unique}");
            Console.WriteLine($"{result}");
        }
    }
}
