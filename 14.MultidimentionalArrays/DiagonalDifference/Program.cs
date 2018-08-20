using System;
using System.Collections.Generic;
using System.Linq;

namespace diagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var primary = new List<int>();
            var secondary = new List<int>();

            var matrix = new int[input, input];

            var secCount = matrix.GetLength(1)-1;
            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }
           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                primary.Add(matrix[i, counter]);
                counter++;
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                secondary.Add(matrix[i, secCount]);
                secCount--;
            }
            int primarySum = primary.Sum();
            int secondarySum = secondary.Sum();
            int result = primarySum - secondarySum;

            Console.WriteLine(Math.Abs(result));
        }
    }
}
