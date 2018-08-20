using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\s[a-zA-Z0-9][\w.-]*\@[a-zA-Z]+)(\.[a-zA-Z-]+)+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);


            foreach (Match item in matches)
            {
                string email = item.ToString();

                Console.WriteLine(item);
            }
        }
    }
}
