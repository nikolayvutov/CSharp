using System;
using System.Collections.Generic;
using System.Linq;


class MaxSequenceOfEqualElements
{
	static void Main()
	{
		List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
		int maxNumbers = 0;
		int count = 1;
		int maxCount = 1;
		int pos = 0;
		while (pos < numbers.Count - 1)
		{

			if (numbers[pos] == numbers[pos + 1])
			{
				count++;

				if (count > maxCount)
				{
					maxCount = count;
					maxNumbers = numbers[pos];
				}

			}
			else
			{
				count = 1;
			}
			pos++;
			if (maxCount == 1)
			{
				maxNumbers = numbers[0];
			}
		}
		for (int i = 0; i < maxCount; i++)
		{
			Console.Write(maxNumbers);
			Console.Write(" ");

		}
	}
}