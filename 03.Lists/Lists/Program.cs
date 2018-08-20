using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class MainClass
    {
        public static void Main()
        {
            List<int> newList = Console.ReadLine()
                                       .Split(new char[] { ' ' },
                                              StringSplitOptions
                                              .RemoveEmptyEntries)
                                       .Select(int.Parse).ToList();

            newList.RemoveAll(x => x < 0);
            newList.Reverse();

            if (newList.Count() == 0)
            {
                Console.WriteLine("empty");
            }

            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
