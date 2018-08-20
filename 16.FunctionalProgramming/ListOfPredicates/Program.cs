using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var nums = Console.ReadLine().Split(new[] { ' ' },
                                                StringSplitOptions
                                                .RemoveEmptyEntries)
                              .Select(int.Parse).Distinct().ToArray();

            var numsList = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                bool shouldAdd = true;
                for (int k = 0; k < nums.Length; k++)
                {
                    if (i % nums[k] != 0)
                    {
                        shouldAdd = false;
                        break;
                    }
                }
                if (shouldAdd)
                {
                    numsList.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", numsList));
        }
    }
}
