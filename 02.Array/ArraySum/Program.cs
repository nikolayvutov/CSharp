using System;
using System.Linq;

namespace ArraySum
{
    class MainClass
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            array[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int result = 0;
                int startIndex = Math.Max(0, i - k);

                for (int j = startIndex; j < n; j++)
                {
                    result += array[j];
                }
                array[i] = result;
            }
            Console.WriteLine(String.Join(" ", array));
        }

    }
}
