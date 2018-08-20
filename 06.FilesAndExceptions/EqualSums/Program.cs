using System;
using System.Linq;
using System.IO;

namespace equalSums
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var input = File.ReadAllText(@"../../../resources/3. Equal Sums/text.txt");


            int[] numbers = input.Split(new char[] { ' ' },
                                                StringSplitOptions
                                                .RemoveEmptyEntries)
                                        .Select(int.Parse).ToArray();

            bool isFindEqualSums = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();

                if (leftSide.Sum() == rightSide.Sum())
                {
                    
                    File.AppendAllText(@"../../../resources/3. Equal Sums/output.txt", i.ToString());
                    isFindEqualSums = true;
                    break;
                }
            }
            if (!isFindEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}