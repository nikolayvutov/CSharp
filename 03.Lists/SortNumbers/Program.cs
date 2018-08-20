using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                                       .Split(new char[] { ' ' },
                                              StringSplitOptions
                                              .RemoveEmptyEntries)
                                           .Select(decimal.Parse).ToList();
            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
