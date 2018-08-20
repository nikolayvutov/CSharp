using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        var input = File.ReadAllText(@"../../../resources/4. Max Sequence of Equal Elements/text.txt");

        File.Delete(@"../../../resources/4. Max Sequence of Equal Elements/output.txt");
        List<int> numbers = input.Split(' ').Select(int.Parse).ToList();
        int maxNumbers = 0;
        int count = 1;
        int maxCount = 1;
        int pos = 0;
        while (pos < numbers.Count - 1)
        {

            if (numbers[pos] == numbers[pos + 1])
            {
                count++;

                if (count > maxCount)
                {
                    maxCount = count;
                    maxNumbers = numbers[pos];
                }

            }
            else
            {
                count = 1;
            }
            pos++;
            if (maxCount == 1)
            {
                maxNumbers = numbers[0];
            }
        }
        List<int> num = new List<int>();


        var output = string.Join(" ", maxNumbers);
        for (int i = 0; i < maxCount; i++)
        {
            File.AppendAllText(@"../../../resources/4. Max Sequence of Equal Elements/output.txt", output);

        }

        //File.AppendAllText(@"../../../resources/4. Max Sequence of Equal Elements/output.txt", output);
    }
}