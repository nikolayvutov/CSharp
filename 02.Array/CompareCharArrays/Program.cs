using System;
using System.Linq;

namespace compareCharArrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int minLength = Math.Min(first.Length, second.Length);
            bool isFirst = false;


            for (int i = 0; i < minLength; i++)
            {
                var firstIndex = (int)first[i];
                var secondIndex = (int)second[i];

                if (firstIndex <= secondIndex)
                {
                    isFirst = true;
                }
                else
                {
                    break;
                }
            }

            if (isFirst)
            {
				Console.WriteLine($"{String.Join("", first)}");
				Console.WriteLine($"{String.Join("", second)}");
            }
            else
            {
                Console.WriteLine($"{String.Join("", second)}");
                Console.WriteLine($"{String.Join("", first)}");
            }

        }
    }
}
