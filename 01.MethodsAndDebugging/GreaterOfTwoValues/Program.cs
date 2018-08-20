using System;

namespace greaterOfTwoValues
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
				GetMax(first, second);
            }
            else if (type == "char")
            {
				char first = char.Parse(Console.ReadLine());
				char second = char.Parse(Console.ReadLine());
				GetMaxChar(first, second);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
				GetMaxString(first, second);
            }
        }


        static void GetMax(int first, int second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }
        static void GetMaxChar(char first, char second)
        {
			if (first > second)
			{
				Console.WriteLine(first);
			}
			else
			{
				Console.WriteLine(second);
			}
        }
        static void GetMaxString(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

    }
}
