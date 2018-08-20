using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regeh
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\[([a-zA-Z]+)\<([0-9]+)REGEH([0-9]+)\>([a-zA-Z]+)\]";

            var input = Console.ReadLine();
            var sum = 0;

            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();
            var list = new List<int>();

            foreach (Match m in matches)
            {
                var firstDigit = int.Parse(m.Groups[2].Value);
                var secondDigit = int.Parse(m.Groups[3].Value);

                list.Add(firstDigit);
                list.Add(secondDigit);
            }

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];

                sb.Append(input[sum % (input.Length -1)]);
            }
            Console.WriteLine(sb);
        }
    }
}
