using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split().ToList();

            Console.WriteLine(names
                              .FirstOrDefault(sum => 
                              sum.ToCharArray().Sum(c => c) >= n));
        }
    }
}
