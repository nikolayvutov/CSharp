using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' },
                                                 StringSplitOptions
                                                 .RemoveEmptyEntries)
                               .Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            input.Reverse();

            Predicate<int> predicate = x => x % n != 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (predicate(input[i]))
                {
                    Console.Write(input[i] + " ");
                }
            }
        }
    }
}
