using System;
using System.Collections.Generic;
using System.Linq;

namespace AMinerTask
{
    class MainClass
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(input))
                {
                    dict[input] += quantity;
                }
                else
                {
                    dict[input] = quantity;
                }


                input = Console.ReadLine();
            }
            foreach (var x in dict)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
}
