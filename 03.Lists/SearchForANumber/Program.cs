using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class MainClass
    {
        public static void Main()
        {
            List<int> newList = Console.ReadLine()
                                       .Split(new char[] { ' ' },
                                              StringSplitOptions
                                              .RemoveEmptyEntries)
                                       .Select(int.Parse).ToList();

            List<int> commands = Console.ReadLine()
                                       .Split(new char[] { ' ' },
                                              StringSplitOptions
                                              .RemoveEmptyEntries)
                                       .Select(int.Parse).ToList();

            List<int> answer = new List<int>();

            int takeElem = commands[0];
            int remElem = commands[1];
            int number = commands[2];

            answer = newList.Take(takeElem).ToList();
            answer.RemoveRange(0, remElem);

            if (answer.Contains(number))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }


        }
    }
}
