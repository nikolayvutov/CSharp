using System;
using System.Collections.Generic;
using System.Linq;

namespace sumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int sum = 0;
            int[][] matrix = new int[nums[0]][];

            for (int i = 0; i < nums[0]; i++)
            {
                var inputNums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
                matrix[i] = new int[inputNums.Length];

                for (int j = 0; j < nums[1]; j++)
                {
                    matrix[i][j] = inputNums[j];
                }
            }

            for (int i = 0; i < nums[0]; i++)
            {
                for (int j = 0; j < nums[1]; j++)
                {
                    sum += matrix[i][j];
                }
            }

            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(sum);

        }
    }
}
