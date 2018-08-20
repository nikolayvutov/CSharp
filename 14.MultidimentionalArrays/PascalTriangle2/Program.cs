using System;

namespace pascalTriangle_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            int currWidth = 1;

            long[][] triangle = new long[height][];

            for (int i = 0; i < height; i++)
            {
                triangle[i] = new long[currWidth];
                triangle[i][0] = 1;
                triangle[i][currWidth - 1] = 1;
                currWidth++;
                if (i >= 2)
                {
                    for (int widthCounter = 1; widthCounter < i; widthCounter++)
                    {
                        triangle[i][widthCounter] =
                            triangle[i - 1][widthCounter - 1] +
                            triangle[i - 1][widthCounter];
                    }
                }
            }

            for (int i = 0; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    Console.Write(triangle[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
