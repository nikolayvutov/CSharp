using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CryptoBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"\{(.*?)(\d+).*?\}";
            string secondPattern = @"\[(.*?)(\d+).*?\]";

            string input = "";

            for (int i = 0; i < n; i++)
            {
                input += Console.ReadLine();
            }

            StringBuilder sb = new StringBuilder();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                sb.Append(m.Groups[2].Value);
            }
            foreach (Match m in Regex.Matches(input, secondPattern))
            {
                sb.Append(m.Groups[2].Value);
            }
            var list = new List<string>();

            for (int i = 0; i < sb.Length; i+= 3)
            {
                list.Add(sb[i].ToString());
                list.Add(sb[i+1].ToString());
                list.Add(sb[i+2].ToString());



            }

            Console.WriteLine(sb);

        }
    }
}
