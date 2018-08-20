using System;
using System.Linq;

namespace _2x2Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions
                                                 .RemoveEmptyEntries)
                               .Select(int.Parse).ToArray();


            var matrix = new string [input[0], input[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    matrix[i, l] = tokens[l];
                }
            }

            int count = 0;
            for (int i = 0; i < matrix.GetLength(0) -1 ; i++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    if (matrix[i,k] == matrix[i,k+1] && matrix[i, k] == matrix[i+1,k] && matrix[i, k] == matrix[i+1,k+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
