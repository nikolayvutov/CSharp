using System;

namespace numbersInReversedOrder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string num = Console.ReadLine();
            Console.WriteLine(ReverseInt(num));
        }
        static string ReverseInt(string num)
		{
            char[] numbers = num.ToCharArray();
            Array.Reverse(numbers);
            return new string(numbers);
		}
    }
}
