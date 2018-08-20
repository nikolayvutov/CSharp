using System;
using System.Linq;

namespace UnicodeCharacters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var chars = input.Select(c => (int)c).Select(c => $@"\u{c:x4}");

            var result = string.Concat(chars);
            Console.WriteLine(result);
        }
    }
}
