using System;
using System.Text;
using System.Linq;

namespace SumBigNumbers
{
    class MainClass
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (first.Length > second.Length)
            {
                second = second.PadLeft(first.Length, '0');
            }
            else
            {
                first = first.PadLeft(second.Length, '0');
            }

            StringBuilder sb = new StringBuilder();
            var sum = 0;
            var number = 0;
            var remainder = 0;

            for (int i = first.Length - 1; i >= 0; i--)
            {
                sum = first[i] - 48 + second[i] - 48 + remainder;
                number = sum % 10;
                sb.Append(number);
                remainder = sum / 10;

                if (i == 0 && remainder > 0)
                {
                    sb.Append(remainder);
                }
            }
            Console.WriteLine(new string(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray()));
        }
    }
}
