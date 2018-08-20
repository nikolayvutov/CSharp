using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse);

            Lake<int> lake = new Lake<int>(input);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
