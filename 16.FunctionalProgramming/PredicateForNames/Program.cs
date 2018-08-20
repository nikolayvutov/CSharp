using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(new[] { ' ' },
                                                 StringSplitOptions
                                                 .RemoveEmptyEntries)
                                                 .ToArray();

            Predicate<string> predicate = x => x.Length <= n;

            foreach (var name in names)
            {
                if (predicate(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
