using System;
using System.Linq;

namespace TargerPrice2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var word = Console.ReadLine().ToCharArray();
            var explosion = Console.ReadLine().Split().ToArray();

            var matrix = new char[nums[0], nums[1]];
            bool isGoingLeft = true;
            int snakeIndex = 0;

            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                int index = isGoingLeft ? matrix.GetLength(1) - 1 : 0;
                int increment = isGoingLeft ? -1 : 1;

                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    matrix[i, index] = word[snakeIndex++];

                    if (snakeIndex >= word.Length)
                    {
                        snakeIndex = 0;
                    }
                    index += increment;
                }
                isGoingLeft = !isGoingLeft;
            }

            int impactRow = int.Parse(explosion[0]);
            int impactCol = int.Parse(explosion[1]);
            int radius = int.Parse(explosion[2]);



            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int a = impactRow - i;
                    int b = impactCol - j;
                    double distance = Math.Sqrt(a * a + b * b);

                    if (distance <= radius)
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }

            int count = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    if (matrix[row,col] == ' ')
                    {
                        count++;
                    }
                    else if (count > 0)
                    {
                        matrix[row + count, col] = matrix[row, col];
                        matrix[row, col] = ' ';
                    }
                }
                count = 0;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
