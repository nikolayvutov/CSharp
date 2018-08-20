using System;

using System.Linq;

namespace MagicExchangeableWords
{
    class MainClass
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t', '\n' },
                                                 StringSplitOptions
                                                 .RemoveEmptyEntries);

            double sum = 0;

            foreach (var item in input)
            {
                var first = item.First();
                var last = item.Last();
                double number = double.Parse(item.Substring(1, item.Length - 2));

                if (char.IsUpper(first))
                {
                    number /= first - 'A' + 1;
                }
                else if(char.IsLower(first))
                {
                    number *= first - 'a' + 1;
                }

                if (char.IsUpper(last))
                {
                    number -= last - 'A' + 1;
                }
                else if (char.IsLower(last))
                {
                    number += last - 'a' + 1;
                }

                sum += number;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
