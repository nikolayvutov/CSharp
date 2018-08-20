using System;

namespace PokeMon
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int count = 0;
            int oldN = n;
            while (n >= m)
            {
                n -= m;

                if (oldN * 50 / 100 == n)
                {
                    n /= y;
                }
                count++;
            }

            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
