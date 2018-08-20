using System;

namespace primeChecker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(PrimeChecker(number));
        }
        static bool PrimeChecker(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
