using System;
using System.Collections.Generic;
using System.Linq;

class PokemonEvolutionUpgrade
{
    public static void Main(string[] args)
    {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        string input;

        while ((input = Console.ReadLine()) != "wubbalubbadubdub")
        {
            string[] commands = input.Split(new string[] { " -> " }, 
                                            StringSplitOptions
                                            .RemoveEmptyEntries);
            if (commands.Length > 1)
            {
                if (!dict.ContainsKey(commands[0]))
                {
                    dict.Add(commands[0], new List<string>());
                }
                string str = commands[1] + " <-> " + commands[2];
                dict[commands[0]].Add(str);

            }
            else if (dict.ContainsKey(commands[0]))
            {
                Console.WriteLine($"# {commands[0]}");
                dict[commands[0]].ForEach(Console.WriteLine);
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"# {item.Key}");

            var ordered = item.Value.OrderByDescending(
                a => {return int.Parse(a.Split(new[] { " <-> " },
                     StringSplitOptions.RemoveEmptyEntries)[1]); });

            foreach (var output in ordered)
            {
                Console.WriteLine(output);
            }
        }
    }
}
