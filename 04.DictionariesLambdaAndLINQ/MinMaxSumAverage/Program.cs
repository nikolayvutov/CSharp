using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMaxSumAverage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum = {array.Sum()}");
            Console.WriteLine($"Min = {array.Min()}");
            Console.WriteLine($"Max = {array.Max()}");
            Console.WriteLine($"Average = {array.Average()}");
        }
    }
}
