using System;
using System.Linq;
using System.Collections.Generic;

namespace maximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' },
                                                 StringSplitOptions
                                                 .RemoveEmptyEntries)
                               .Select(int.Parse).ToArray();

            var matrix = new int[input[0], input[1]];

            for (int l = 0; l < matrix.GetLength(0); l++)
            {
                var tokens = Console.ReadLine().Split(new char[] { ' ' },
                                                      StringSplitOptions
                                                      .RemoveEmptyEntries)
                                    .Select(int.Parse).ToArray();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[l, k] = tokens[k];
                }

            }

            int sum = 0;
            int tempSum = 0;
            var startIndex = new int[2];



            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    tempSum = matrix[i, j] +
                        matrix[i, j + 1] +
                        matrix[i, j + 2] +
                        matrix[i + 1, j] +
                        matrix[i + 1, j + 1] +
                        matrix[i + 1, j + 2] +
                        matrix[i + 2, j] +
                        matrix[i + 2, j + 1] +
                        matrix[i + 2, j + 2];

                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        startIndex[0] = i;
                        startIndex[1] = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int i = startIndex[0]; i < startIndex[0] + 3; i++)
            {
                for (int k = startIndex[1]; k < startIndex[1] + 3; k++)
                {
                    Console.Write(matrix[i, k] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
