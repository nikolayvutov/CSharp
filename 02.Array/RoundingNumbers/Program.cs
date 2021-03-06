﻿using System;
using System.Linq;

namespace roundingNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ')
                                   .Select(double.Parse).ToArray();

            foreach (var x in nums)
            {
                double rounded = Math.Round(x, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{x} => {rounded}");
            }
        }
    }
}
