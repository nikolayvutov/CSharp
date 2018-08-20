using System;
using System.Linq;
using System.Collections.Generic;

namespace ExtractEmails
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var text = Console.ReadLine().Split('|');

            var m = input[0];
            var n = input[1];

            List<string> myList = new List<string>();

            foreach (var item in text)
            {
                
                if (item.StartsWith("<"))
                {
                    string word;
                    if (m+n > item.Length-1)
                    {
                        word = item.Substring(m + 1);
                    }
                    else
                    {
                        word = item.Substring(m + 1, n);
                    }
                    myList.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", myList));
        }
    }
}
