using System;
using System.Linq;
using System.IO;


namespace MostFrequentNumber
{
    class Program
    {
        static void Main()
        {
            File.Delete(@"../../../resources/1. Most Frequent Number/output.txt");

            string input = File.ReadAllText(@"../../../resources/1. Most Frequent Number/text.txt");

            ushort[] array = input.Split(' ').Select(ushort.Parse).ToArray();
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
                    string output = array[i].ToString();
                    File.WriteAllText(@"../../../resources/1. Most Frequent Number/output.txt", output);
                    return;
                }
            }
        }
    }
}