using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HitList
{
    class Program
    {
        static void Main(string[] args)
        {
            int infoIndex = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, string>>();

            string input;
            while ((input = Console.ReadLine()) != "end transmissions")
            {
                var firstSplit = input.Split(new[] { '=' }, StringSplitOptions
                                         .RemoveEmptyEntries).ToArray();

                string name = firstSplit[0];
                string other = firstSplit[1];



                var commands = other.Split(new[] { ';' }, StringSplitOptions
                                         .RemoveEmptyEntries).ToArray();

                foreach (var com in commands)
                {
                    var tokens = com.Split(new[] { ':'}, StringSplitOptions
                                         .RemoveEmptyEntries).ToArray();
                    
                    string inputKey = tokens[0];
                    string inputValue = tokens[1];

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new Dictionary<string, string>());
                        dict[name].Add(inputKey, inputValue);
                    }
                    else
                    {
                        dict[name][inputKey] = inputValue;
                    }

                }
            }

            var finalInput = Console.ReadLine().Split(new[] { ' ' },
                                                      StringSplitOptions
                                                      .RemoveEmptyEntries)
                                    .ToArray();

            string killName = finalInput[1];
            int infoSum = 0;

            foreach (var name in dict)
            {
                if (name.Key == killName)
                {
                    Console.WriteLine($"Info on {killName}:");
                    foreach (var keyValuePair in name.Value.OrderBy(x => x.Key))
                    {
                        string key = keyValuePair.Key;
                        string value = keyValuePair.Value;
                        infoSum += key.Length;
                        infoSum += value.Length;

                        Console.WriteLine($"---{key}: {value}");

                    }
                    Console.WriteLine($"Info index: {infoSum}");

                    if (infoSum >= infoIndex)
                    {
                        Console.WriteLine("Proceed");
                    }
                    else
                    {
                        Console.WriteLine($"Need {infoIndex - infoSum} more info.");
                    }
                }
            }

        }
    }
}
