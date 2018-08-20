using System;

namespace printTriangle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
		static void PrintLine(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				Console.Write($"{i} ");
			}
			Console.WriteLine();
		}

        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
            {
                PrintLine(line);
            }
            for (int line = n-1; line >= 1; line--)
            {
                PrintLine(line);
            }
        }

    }
}
