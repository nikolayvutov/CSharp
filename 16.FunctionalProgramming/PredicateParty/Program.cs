using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new[] { ' ' },
                                                 StringSplitOptions
                                                 .RemoveEmptyEntries)
                               .ToList();
            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                var tokens = input.Split(new[] { ' ' }, StringSplitOptions
                                         .RemoveEmptyEntries).ToArray();


                switch (tokens[1])
                {
                    case "StartsWith":
                        ForeachName(tokens[0], names, n => n.StartsWith(tokens[2]));
                        break;
                    case "EndsWith":
                        ForeachName(tokens[0], names, n => n.EndsWith(tokens[2]));
                        break;
                    case "Length":
                        ForeachName(tokens[0], names, n => n.Length == int.Parse(tokens[2]));
                        break;
                }
            } 


            if (names.Count > 0)
            {
                string finalNames = string.Join(", ", names);
                Console.WriteLine($"{finalNames} are going to the party!");
            }
            else 
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void ForeachName(string command, List<string> names, Func<string, bool> condition)
        {
            for (int i = names.Count - 1; i >= 0; i--)
            {
                if (condition(names[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            names.RemoveAt(i);
                            break;
                        case "Double":
                            names.Insert(i, names[i]);
                            break;
                    }
                }
            }
        }
    }
}
