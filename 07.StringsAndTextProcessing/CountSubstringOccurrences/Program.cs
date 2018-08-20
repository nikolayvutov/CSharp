using System;
using System.Linq;

namespace CountSubstringOccurrences
{
    class MainClass
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string command = Console.ReadLine().ToLower();

            int counter = 0;
            var index = -1;

            while (true)
            {
                index = input.IndexOf(command, index+1);
                if (index == -1)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
