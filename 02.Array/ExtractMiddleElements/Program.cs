using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extractMiddleElements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' },
                                                   StringSplitOptions
                                                   .RemoveEmptyEntries)
                                 .Select(int.Parse).ToArray();

            int startIndex = Math.Max(0, array.Length / 2 - 1);
            int endIndex = startIndex + 1;

            if (array.Length == 1)
            {
                endIndex = 0;
            }
            else if (array.Length % 2 != 0)
            {
                endIndex++;
            }

            HashSet<int> middleElements = new HashSet<int>();
            for (int i = startIndex; i <= endIndex; i++)
            {
                middleElements.Add(array[i]);
            }
            Console.WriteLine("{" + string.Join(", ", middleElements) + " }");

        }
    }
}
