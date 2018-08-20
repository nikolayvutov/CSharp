using System;

namespace HornetWings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            decimal m = decimal.Parse(Console.ReadLine());
            long p = long.Parse(Console.ReadLine());

            long rest = n / p;

            var meters = (n / 1000) * m;
            long seconds = rest * 5;

            seconds += (n / 100);

            Console.WriteLine($"{meters:F2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}
