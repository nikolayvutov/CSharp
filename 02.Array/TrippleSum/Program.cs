using System;
using System.Linq;

namespace trippleSum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();
            int counter = 0;

            for (int a = 0; a < array.Length; a++)
            {
                for (int b = a+1; b < array.Length; b++)
                {
                    int sum = array[a] + array[b];
                    if (array.Contains(sum))
                    {
                        Console.WriteLine($"{array[a]} + {array[b]} == {sum}");
                        counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
