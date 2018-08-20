using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    class MainClass
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ',',','!','.','?','-'},
                                                   StringSplitOptions
                                                   .RemoveEmptyEntries)
                                 .ToArray();

            List<string> myList = new List<string>();
            foreach (var word in text)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    if (!myList.Contains(word))
                    {
                        myList.Add(word);
                    }
                }
            }

            myList = myList.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", myList));


        }
    }
}
