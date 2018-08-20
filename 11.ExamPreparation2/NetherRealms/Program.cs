using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace NetherRealms
{
    class MainClass
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new string[]{", "},
                                                      StringSplitOptions
                                                      .RemoveEmptyEntries);

            var healthPattern = @"[A-Za-z]";
            var numberPattern = @"[-?\d.]";
            var symbolsPattern = @"[*\/]";

            double health;
            double damage;

            foreach (var item in input)
            {
                Regex number = 

            }



        }
    }
}
