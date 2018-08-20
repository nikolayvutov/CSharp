using System;
using System.Collections.Generic;
using System.Linq;

namespace PhonebookUpgrade
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ' },
                                                          StringSplitOptions
                                                          .RemoveEmptyEntries)
                                        .ToList();
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    dict[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {dict[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }

                }


                input = Console.ReadLine().Split(new char[] { ' ' },
                                                          StringSplitOptions
                                                          .RemoveEmptyEntries)
                                        .ToList();
            }
        }
    }
}
