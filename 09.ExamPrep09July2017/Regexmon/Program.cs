using System;
using System.Text.RegularExpressions;

namespace Regexmon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var bojoMon = @"[A-Za-z]+-[A-Za-z]+";
            var didiMon = @"[^A-Za-z-]+";

            string input = Console.ReadLine();

            while (true)
            {
                Match didiMatch = Regex.Match(input, didiMon);

                if (didiMatch.Success)
                {
                    Console.WriteLine(didiMatch.Value.ToString());
                }
                else
                {
                    return;
                }

                int firstSymbolDidi = didiMatch.Index;
                input = input.Substring(firstSymbolDidi + didiMatch.Length);

                Match bojoMatch = Regex.Match(input, bojoMon);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value.ToString());
                }
                else
                {
                    return;
                }

                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);
            }
        }
    }
}
