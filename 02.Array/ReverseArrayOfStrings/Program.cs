using System;
using System.Linq;

namespace reverseArrayOfStrings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Console.ReadLine().Split(' ').ToArray().Reverse()));
        }
    }
}
