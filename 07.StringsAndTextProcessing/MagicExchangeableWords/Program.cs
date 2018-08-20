using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MagicExchangeableWords
{
    class MainClass
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            var first = input[0].ToCharArray().Distinct().ToArray();
            var second = input[1].ToCharArray().Distinct().ToArray();

            if (first.Length == second.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
