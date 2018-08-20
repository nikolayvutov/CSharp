using System;
using System.IO;

namespace indexOfLetters
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            File.Delete(@"../../../resources/2. Index of Letters/output.txt");

            string input = File.ReadAllText(@"../../../resources/2. Index of Letters/text.txt");
            char[] inputChar = input.ToCharArray();

            for (int i = 0; i < inputChar.Length; i++)
            {

                char[] item = $"{input[i]} -> {input[i] - 97}".ToCharArray();

                File.AppendAllText(@"../../../resources/2. Index of Letters/output.txt", new string(item) + Environment.NewLine);
            }
        }
    }
}