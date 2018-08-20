using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class MainClass
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(new char[]{' '},
                                              StringSplitOptions
                                              .RemoveEmptyEntries)
                                       .Select(int.Parse).ToList();
            int start = 0;
            int bestStart = 0;
            int length = 1;
            int bestLength = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    length++;
                    if (length > bestLength)
                    {
                        bestStart = start;
                        bestLength = length;
                    }
                }
                else
                {
                    start = i;
                    length = 1;
                }
            }
            for (int i = bestStart; i < bestStart+bestLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
