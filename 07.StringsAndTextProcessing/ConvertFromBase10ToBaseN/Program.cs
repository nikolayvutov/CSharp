using System;
using System.Collections.Generic;
using System.Linq;
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

            List<BigInteger> list = new List<BigInteger>();

            while (number != 0)
            {
                BigInteger remainder = number % baseNum;
                list.Add(remainder);
                number /= baseNum;
            }
            list.Reverse();
            Console.WriteLine(string.Join("", list));

        }
    }
}
