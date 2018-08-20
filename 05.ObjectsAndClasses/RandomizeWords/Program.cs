using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomizeWords
{
    class MainClass
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                                  .Split(new char[] { ' ' },
                                         StringSplitOptions.RemoveEmptyEntries);


            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
