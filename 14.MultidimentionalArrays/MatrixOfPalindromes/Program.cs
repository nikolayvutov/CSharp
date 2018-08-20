using System;
using System.Linq;

namespace matrixOfPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int row = 97; row < 97 + nums[0]; row++)
            {
                for (int col = row; col < row + nums[1]; col++)
                {
                    Console.Write($"{(char)row}{(char)col}{(char)row} ");
                }
                Console.WriteLine();
            }
        }
    }
}
