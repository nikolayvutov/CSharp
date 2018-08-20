using System;
using System.Linq;

namespace rotateAndSum
{
    class MainClass
    {
        public static void Main()
        {
			int[] numbers = Console.ReadLine()
										.Split(new char[] { ' ' },
											   StringSplitOptions
											   .RemoveEmptyEntries)
									   .Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];

            for (int j = 0; j < rotation; j++)
            {
                int reminder = numbers[numbers.Length - 1];

				for (int i = numbers.Length - 1; i > 0; i--)
				{
					numbers[i] = numbers[i - 1];
					sum[i] += numbers[i];
				}
				numbers[0] = reminder;
				sum[0] += numbers[0];
            }

            Console.WriteLine($"{String.Join(" ", sum)}");
        }
    }
}
