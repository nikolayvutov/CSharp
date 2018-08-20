using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchDates
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string pattern = @"\b(\d{2})([\/\-.])([A-Z][a-z]{2})(\2)(\d{4})\b";

            string input = Console.ReadLine();

            var dates = Regex.Matches(input, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups[1].Value;
                var month = date.Groups[3].Value;
                var year = date.Groups[5].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
