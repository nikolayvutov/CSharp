using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split(new char[] { ' ' }
                                                       , StringSplitOptions
                                                       .RemoveEmptyEntries)
                                         .Select(decimal.Parse).ToList();

            bool hasSummed = true;

            while (hasSummed)
            {
				decimal sum = 0;
				int index = 0;
                hasSummed = false;

                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i] == input[i - 1])
                    {
                        index = i - 1;
                        sum = input[i] + input[i - 1];
                        hasSummed = true;
                        break;
                    }
                }
                if (hasSummed)
                {
                    input.RemoveRange(index, 2);
                    input.Insert(index, sum);
                }
            }
        }
    }
}
