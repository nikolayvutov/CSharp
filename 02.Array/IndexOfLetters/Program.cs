using System;

namespace indexOfLetters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {input[i] - 97}");
            }
        }
    }
}
