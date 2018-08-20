using System;
using System.Linq;
using System.Collections.Generic;

namespace squareWithMaximumSUm
{
    class Program
    {
        internal static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();


            var jagged = new int[nums[0]][];

            for (int row = 0; row < nums[0]; row++)
            {
                var input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
                jagged[row] = new int[input.Length];

                for (int col = 0; col < nums[1]; col++)
                {
                    jagged[row][col] = input[col];
                }
            }
            int sum = 0;
            int rowIndex = 0, colIndex = 0;

            for (int i = 0; i < nums[0] - 1; i++)
            {
                for (int j = 0; j < nums[1] - 1; j++)
                {
                    
                    var tempSum = jagged[i][j] +
                        jagged[i][j + 1] +
                        jagged[i + 1][j] +
                        jagged[i + 1][j + 1];


                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        rowIndex = i;
                        colIndex = j;
                    }
                }
            }

            Console.WriteLine(jagged[rowIndex][colIndex] + " " + jagged[rowIndex][colIndex + 1]);
            Console.WriteLine(jagged[rowIndex + 1][colIndex] + " " + jagged[rowIndex + 1][colIndex + 1]);
            Console.WriteLine(sum);
        }
    }
}
