using System;
using System.Linq;

namespace rotateAndSum
{
	class MainClass
	{
		public static void Main()
		{
			string[] first = Console.ReadLine()
				.Split(new char[] { ' ' },
				StringSplitOptions
				.RemoveEmptyEntries);

			string[] second = Console.ReadLine()
				.Split(new char[] { ' ' },
				StringSplitOptions
				.RemoveEmptyEntries);

			int leftCount = FindMaxCommonItems(first, second);

			Array.Reverse(first);
			Array.Reverse(second);
			int rightCount = FindMaxCommonItems(first, second);

			Console.WriteLine($"{Math.Max(leftCount, rightCount)}");


		}
		static int FindMaxCommonItems(string[] first, string[] second)
		{
			int lenght = Math.Min(first.Length, second.Length);
			int count = 0;

			for (int i = 0; i < lenght; i++)
			{
				if (first[i] == second[i])
				{
					count++;
				}
				else
				{
					break;
				}
			}
			return count;
		}
	}
}
