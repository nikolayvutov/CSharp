using System;
using System.Linq;

namespace lastKNumbersSums
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            arr[0] = 1;


            for (int i = 1; i < n; i++)
            {
                int result = 0;
                for (int j = i - 1; j >= i - k - 1; j--)
                {
                    result += arr[j];

                }
                arr[i] = result;
            }
            Console.WriteLine(string.Join(" ", arr));

        }
    }
}