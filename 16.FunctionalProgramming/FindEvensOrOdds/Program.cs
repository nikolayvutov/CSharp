using System;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' },
                                                 StringSplitOptions
                                                 .RemoveEmptyEntries)
                               .Select(int.Parse).ToArray();

            int start = input[0];
            int end = input[1];

            var rules = Console.ReadLine();

            Predicate<int> func = a => a % 2 != 0;

            if (rules == "even")
            {
                for (int i = start; i <= end; i++)
                {
                    if (func(i) == false)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    if (func(i) == true)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

        }
    }
}
