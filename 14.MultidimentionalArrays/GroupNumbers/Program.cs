using System;
using System.Linq;

namespace groupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", input.Where(x => Math.Abs(x) % 3 == 0)));
            Console.WriteLine(string.Join(" ", input.Where(x => Math.Abs(x) % 3 == 1)));
            Console.WriteLine(string.Join(" ", input.Where(x => Math.Abs(x) % 3 == 2)));
        }
    }
}
