using System;
using System.Linq;
using System.Collections.Generic;

namespace LettersChangeNumbers
{
    class MainClass
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var sum = 0;
            var first = input[0];
            var second = input[1];

            var minLength = Math.Min(input[0].Length, input[1].Length);
            var maxLenth = Math.Max(input[0].Length, input[1].Length);

            for (int i = 0; i < minLength; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length != second.Length)
            {
                if (first.Length > second.Length)
                {
                    for (int i = minLength; i < maxLenth; i++)
                    {
                        sum += first[i];
                    }
                }
                else
                {
                    for (int i = minLength; i < maxLenth; i++)
                    {
                        sum += second[i];
                    }
                }

            }

            Console.WriteLine(sum);
        }
    }
}
