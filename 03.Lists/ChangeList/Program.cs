using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class MainClass
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (!(input == "Odd" || input == "Even"))
            {
                var tokens = input.Split();
                var command = tokens[0];


                if (command == "Delete")
                {
                    var element = int.Parse(tokens[1]);
                    numbers.RemoveAll(x => x == element);
                }
                else if (command == "Insert")
                {
                    var index = int.Parse(tokens[2]);
                    var element = int.Parse(tokens[1]);
                    numbers.Insert(index, element);
                }

                input = Console.ReadLine();


            }

            if (input != "Even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
            }


        }
    }
}
