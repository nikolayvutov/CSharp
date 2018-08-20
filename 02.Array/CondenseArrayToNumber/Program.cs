using System;
using System.Linq;

namespace condenseArrayToNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' },
                                                   StringSplitOptions
                                                   .RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();

            while (array.Length > 1)
            {
                int[] condensedArray = new int[array.Length - 1];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    condensedArray[i] = array[i] + array[i + 1];
                }
                array = condensedArray;
            }
            Console.WriteLine(array[0]);
        }
    }
}
