using System;
using System.Collections.Generic;
using System.Linq;

namespace CubicAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, long>>();
            const long maxCount = 1000000;

            string input = Console.ReadLine();

            while (input != "Count em all")
            {

                var tokens = input.Split(new string[] { " -> " }, StringSplitOptions
                                         .RemoveEmptyEntries);

                string regionName = tokens[0];
                string meteorType = tokens[1];
                long count = long.Parse(tokens[2]);

                if (!dict.ContainsKey(regionName))
                {
                    dict.Add(regionName, new Dictionary<string, long>());
                    dict[regionName].Add("Black", 0);
                    dict[regionName].Add("Green", 0);
                    dict[regionName].Add("Red", 0);
                }

                dict[regionName][meteorType] += count;

                bool isBigger = true;

                if (count >= maxCount && meteorType == "Red")
                {
                    while (isBigger)
                    {
                        dict[regionName]["Red"] -= maxCount;
                        dict[regionName]["Black"] += 1;
                        count -= maxCount;

                        if (count < maxCount)
                        {
                            isBigger = false;
                        }
                    }

                }

                if (count >= maxCount && meteorType == "Green")
                {
                    while (isBigger)
                    {
                        dict[regionName]["Green"] -= maxCount;
                        dict[regionName]["Red"] += 1;

                        if (dict[regionName]["Red"] >= maxCount)
                        {
                            dict[regionName]["Red"] -= maxCount;
                            dict[regionName]["Black"] += 1;
                        }

                        count -= maxCount;

                        if (count < maxCount)
                        {
                            isBigger = false;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var i in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"-> {i.Key} : {i.Value}");
                }
            }
        }
    }
}