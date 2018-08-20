using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                 .Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();

            Console.WriteLine($"{String.Join(" ", input.OrderByDescending(x => x).Take(3))}");
        }
    }
}
