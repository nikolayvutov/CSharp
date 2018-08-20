using System;
using System.Numerics;

namespace BigFactorial
{
    class MainClass
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine(f);
        }
    }
}
