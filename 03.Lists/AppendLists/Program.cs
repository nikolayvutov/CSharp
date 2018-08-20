using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendLists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');

            List<int> lists = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int[] elements = input[i].Split(new char[] { ' ' }, StringSplitOptions
                                                .RemoveEmptyEntries).Select(int.Parse)
                                         .ToArray();

                lists.AddRange(elements);
            }

            Console.WriteLine(string.Join(" ", lists));
        }
    }
}
