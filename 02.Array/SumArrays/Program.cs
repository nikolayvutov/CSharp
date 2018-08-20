using System;
using System.Linq;

namespace sumArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(new char[] { ' ' },
                                                   StringSplitOptions
                                                   .RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();

			int[] second = Console.ReadLine().Split(new char[] { ' ' },
												   StringSplitOptions
												   .RemoveEmptyEntries)
								 .Select(int.Parse).ToArray();


            int sumLength = Math.Max(first.Length, second.Length);

            for (int i = 0; i < sumLength; i++)
            {
                long sum = first[i % first.Length] + second[i % second.Length];

                Console.Write($"{sum} ");
            }
        }
    }
}
