using System;

namespace maxMethod
{
    class MainClass
    {
        static int c;
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a, b));
        }

        static int GetMax(int a, int b)
        {
            int result = Math.Max(a, b);
            int max = result;
            int sum = Math.Max(result, c);
            return sum;
        }
    }
}
