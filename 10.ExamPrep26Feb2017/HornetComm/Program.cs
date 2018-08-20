using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class MainClass
    {
        public static void Main()
        {
            string messageRegex = @"^([\d]+) <-> ([0-9a-zA-Z]+)$";
            string broadcastRegex = @"^([\D]+) <-> ([0-9a-zA-Z]+)$";

            Regex message = new Regex(messageRegex);
            Regex broadcast = new Regex(broadcastRegex);

            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string input;
            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                var inputArgs = input.Split(new string[] { " <-> " },
                                                StringSplitOptions
                                                .RemoveEmptyEntries);
                    
                
                if (message.IsMatch(input))
                {
                    messages.Add($"{string.Join("", inputArgs[0].ToCharArray().Reverse())} " +
                                 $"-> {inputArgs[1]}");
                
                }
                if (broadcast.IsMatch(input))
                {
                    StringBuilder sb = new StringBuilder();

                    foreach (var c in inputArgs[1].ToCharArray())
                    {
                        if (Char.IsLower(c))
                        {
                            sb.Append(Char.ToUpper(c));
                            continue;
                        }
                        if (Char.IsUpper(c))
                        {
                            sb.Append(Char.ToLower(c));
                            continue;
                        }

                        sb.Append(c);
                    }

                    broadcasts.Add($"{sb} -> {inputArgs[0]}");
                }
            }

            Console.WriteLine("Broadcasts:");
            PrintCollection(broadcasts);
            Console.WriteLine("Messages:");
            PrintCollection(messages);

        }
        public static void PrintCollection(List<string> collection)
        {
            if (collection.Count != 0)
            {
                foreach (var current in collection)
                {
                    Console.WriteLine(current);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
