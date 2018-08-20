using System;
using System.Linq;

namespace CrossFire
{
    class Program
    {
        static int[,] matrix;

        static void Main(string[] args)
        {
            var dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            FillMatrix(dimentions);

            string input;
            while ((input = Console.ReadLine()) != "Nuke it from orbit")
            {
                var comands = input.Split().Select(int.Parse).ToArray();

                int targetRow = comands[0];
                int targetCol = comands[1];
                int radius = comands[2];

                FireShot(targetRow, targetCol, radius);

                int count = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col <= matrix.GetLength(1) - 1; col++)
                    {
                        if (matrix[row, col] == 0)
                        {
                            count++;
                        }
                        else if (count > 0)
                        {
                            matrix[row, col - count] = matrix[row, col];
                            matrix[row, col] = 0;
                        }
                    }

                    count = 0;
                }

            }

            var stringMatrix = new string[dimentions[0], dimentions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        stringMatrix[i, j] = " ";
                    }
                    else
                    {
                        stringMatrix[i, j] = matrix[i, j].ToString();
                    }
                }
            }


            for (int i = 0; i < stringMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < stringMatrix.GetLength(1); j++)
                {
                    Console.Write(stringMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

        private static void FireShot(int targetRow, int targetCol, int radius)
        {
            var upRadius = Math.Max(targetCol - radius, 0);
            var downRadius = Math.Min(targetCol + radius, matrix.GetLength(1) - 1);
            var leftRadius = Math.Max(targetRow - radius, 0);
            var rightRadius = Math.Min(targetRow + radius, matrix.GetLength(0) - 1);


            for (int i = leftRadius; i <= rightRadius; i++)
            {
                if (i == targetRow)
                {
                    for (int j = upRadius; j <= downRadius; j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                        matrix[i, j] = 0;
                        }
                    }
                }

            }

            for (int i = leftRadius; i <= rightRadius; i++)
            {
                for (int j = upRadius; j <= downRadius; j++)
                {
                    if (j == targetCol)
                    {
                        if (matrix[i, j] != 0)
                        {
                        matrix[i, j] = 0;
                        }
                    }
                }

            }
        }

        private static void FillMatrix(int[] dimentions)
        {
            int count = 1;

            matrix = new int[dimentions[0], dimentions[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = count;
                    count++;
                }
            }
        }


        private static void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}