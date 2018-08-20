using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionariesLambdaAndLINQ
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ')
                                        .Select(double.Parse).ToList();

            var numbers = new SortedDictionary<double, int>();

            foreach (var x in input)
            {
                if (numbers.ContainsKey(x))
                {
                    numbers[x]++;
                }
                else
                {
                    numbers[x] = 1;
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
