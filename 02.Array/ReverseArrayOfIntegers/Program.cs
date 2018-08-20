using System;

namespace reverseArrayOfIntegers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] numbers = new int[number];

            for (int i = 0; i < number; i++)
            {
                numbers[i]= int.Parse(Console.ReadLine());

            }
            Array.Reverse(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
