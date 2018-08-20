using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonEvolution
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var n = Console.ReadLine();

            Dictionary<string, Dictionary<List<string>, long>> dict = new 
                Dictionary<string, Dictionary<List<string>, long>>();


            while (n != "wubbalubbadubdub")
            {

                var input = n.Split(new char[] { ' ' },
                                                 StringSplitOptions
                                                 .RemoveEmptyEntries).ToArray();

                string name = input[0].Trim();

                if (input.Length < 2)
                {
                    if (dict.ContainsKey(name))
                    {
                        foreach (var x in dict.Where(k => k.Key.Contains(name)))
                        {
                            Console.WriteLine($"# {x.Key}");
                            foreach (var y in x.Value)
                            {
                                Console.WriteLine($"{string.Join("", y.Key)} <-> {y.Value}");
                            }
                        }
                    }
                }
                else
                {
                    string type = input[2].Trim();
                    long evolIndex = long.Parse(input[4].Trim());

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new Dictionary<List<string>, long>());
                        List<string> evo = new List<string>();
                        evo.Add(type);
                        dict[name].Add(evo, evolIndex);
                    }
                    else
                    {
                        List<string> evo = new List<string>();
                        evo.Add(type);
                        dict[name].Add(evo, evolIndex);
                    }
                }



                n = Console.ReadLine();
            }

            foreach (var x in dict)
            {
                Console.WriteLine($"# {x.Key}");
                foreach (var y in x.Value.OrderByDescending(k => k.Value))
                {
                    Console.WriteLine($"{string.Join("", y.Key)} <-> {y.Value}");
                }
            }

        }
    }
}
