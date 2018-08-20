using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int special = commands[0];
            int power = commands[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == special)
                {
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, numbers.Count - 1);

                    int length = right - left + 1;
                    numbers.RemoveRange(left, length);
                    i = 0;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
