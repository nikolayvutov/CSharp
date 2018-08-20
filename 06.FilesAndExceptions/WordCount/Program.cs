using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace WordCount
{
    class MainClass
    {
        public static void Main()
        {
            string text = File.ReadAllText(@"../../../Resources/03. Word Count/text.txt").ToLower();

            string[] chars = text.Split(new char[]{'\n', '\r', ' ', '.', ',', '!', '?', '-'}, 
                                        StringSplitOptions
                                        .RemoveEmptyEntries).ToArray();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var ch in chars)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict[ch] = 1;
                }
                else
                {
                    dict[ch]++;
                }
            }

            string[] words = File.ReadAllText(@"../../../Resources/03. Word Count/words.txt").ToLower()
                                 .Split(new char[]{' ', '-'}, 
                                        StringSplitOptions
                                        .RemoveEmptyEntries).ToArray();


            foreach (var x in dict.OrderByDescending(x => x.Value))
            {
                if (words.Contains(x.Key))
                {
                    File.AppendAllText(@"../../../Resources/03. Word Count/output.txt", $"{x.Key} - {x.Value}" + Environment.NewLine);
                }
            }

        }
    }
}
