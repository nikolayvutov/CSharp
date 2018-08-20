using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string regex = @"(\+359 [2] [0-9]{3} [0-9]{4})\b|(\+359\-[2]\-[0-9]{3}\-[0-9]{4})\b";

            string input = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(input, regex);

            var matchPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchPhones));
        }
    }
}
