using System;

namespace multiplyEvensByOdds
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            input = Math.Abs(input);

            while (input > 0)
            {
                Console.WriteLine(input% 10);
                input /= 10;
            }
        }

    }
}
