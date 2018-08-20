using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RoliTheCoder
{
    class MainClass
    {
        public static void Main()
        {
            Dictionary<int, Dictionary<string, List<string>>> dict = new 
                Dictionary<int, Dictionary<string, List<string>>>();


            string pattern = @"(\d+) #(\w+)(?: (@.+))*";

            string input;

            while ((input = Console.ReadLine()) != "Time for Code")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    int ID = int.Parse(match.Groups[1].Value);
                    string eventName = match.Groups[2].Value;
                    List<string> participants = match.Groups[3].Value
                                                     .Split(" "
                                                            .ToCharArray(),
                                                            StringSplitOptions
                                                            .RemoveEmptyEntries)
                                                     .ToList();


                    if (!dict.ContainsKey(ID))
                    {
                        dict[ID] = new Dictionary<string, List<string>>();
                        dict[ID][eventName] = new List<string>();
                    }

                    if (dict[ID].ContainsKey(eventName))
                    {
                        dict[ID][eventName].AddRange(participants);
                    }
                }
            }

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach (var item in dict.Values)
            {
                foreach (var inner in item)
                {
                    result[inner.Key] = new List<string>();
                    result[inner.Key].AddRange(inner.Value.Distinct());
                }
            }


            foreach (var item in result.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Count}");

                foreach (var part in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"{part}");
                }
            }
        }
    }
}
