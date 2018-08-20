using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ' ' },
                                                StringSplitOptions
                                                .RemoveEmptyEntries)
                              .Select(int.Parse).ToArray();

            var even = new List<int>();
            var odd = new List<int>();

            Predicate<int> predicate = n => n % 2 == 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (predicate(nums[i]))
                {
                    even.Add(nums[i]);
                }
                else 
                {
                    odd.Add(nums[i]);
                }
            }

            even.Sort();
            odd.Sort();

            Console.Write(string.Join(" ", even));
            Console.Write(" ");
            Console.Write(string.Join(" ", odd));
        }
    }
}
