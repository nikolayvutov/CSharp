using System;
using System.Linq;


namespace MostFrequentNumber
{
	class Program
	{
		static void Main()
		{
			ushort[] array = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int[] count = new int[65535];

			foreach (ushort num in array)
			{
				count[num]++;
			}

			int maxValue = count.Max();

			for (int i = 0; i < array.Length; i++)
			{
				if (count[array[i]] == maxValue)
				{
					Console.WriteLine(array[i]);
					return;
				}
			}
		}
	}
}