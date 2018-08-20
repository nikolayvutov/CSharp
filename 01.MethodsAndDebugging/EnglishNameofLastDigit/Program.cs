using System;
using System.Linq;

namespace englishNameofLastDigit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int digit = int.Parse(number[number.Length - 1].ToString());

            Console.WriteLine(DigitInWord(digit));

        }
        static string DigitInWord(int digit)
        {
            string names = "zero,one,two,three,four,five,six,seven,eight,nine";
            string[] digitName = names.Split(',').ToArray();

            for (int i = 0; i < digitName.Length; i++)
            {
                if (digit == i)
                {
                    return digitName[i];
                }
            }
            return string.Empty;
        }

    }
}
