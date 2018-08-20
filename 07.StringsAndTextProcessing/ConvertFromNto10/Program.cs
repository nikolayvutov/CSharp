using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConvertFromBase10ToBaseN
{
    class MainClass
    {
        public static void Main()
        {

            var numbers = Console.ReadLine().Split(' ');

            BigInteger baseNum = BigInteger.Parse(numbers[0]);
            BigInteger number = BigInteger.Parse(numbers[1]);

            int count = 0;
            BigInteger num = 0;

            while (number != 0)
            {
                BigInteger remainder = number % 10;
                num += remainder * BigInteger.Pow(baseNum, count);
                number /= 10;
                count++;
            }

            Console.WriteLine(num);

        }
    }
}
