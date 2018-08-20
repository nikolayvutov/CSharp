using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    class MainClass
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int rev = 0;
                while (numbers[i] > 0)
                {
                    int n = numbers[i] % 10;
                    rev = rev * 10 + n;
                    numbers[i] /= 10;
                }
                sum += rev;

            }
            Console.WriteLine(sum);
        }
    }
}
