using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldAndSum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse)
                                  .ToArray();

            int k = number.Length / 4;

            int[] row1Left = number.Take(k).Reverse().ToArray();
            int[] row1Right = number.Reverse().Take(k).ToArray();
            int[] row1 = row1Left.Concat(row1Right).ToArray();
            int[] row2 = number.Skip(k).Take(2 * k).ToArray();

            var SumArray = row1.Select((x, i) => x + row2[i]);
            Console.WriteLine(string.Join(" ", SumArray));
        }
    }
}
