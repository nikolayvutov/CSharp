using System;
using System.Text.RegularExpressions;

namespace ReplaceATag
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(input, pattern, replacement);

                Console.WriteLine(replaced);

                input = Console.ReadLine();
            }
        }
    }
}
