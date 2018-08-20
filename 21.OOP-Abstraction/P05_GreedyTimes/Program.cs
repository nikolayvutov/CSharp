using System;
using System.Collections.Generic;
using System.Linq;

public class Potato
{
    private static Dictionary<string, Dictionary<string, long>> bag;
    private static long gold = 0;
    private static long gems = 0;
    private static long cash = 0;

    static void Main(string[] args)
    {
        long input = long.Parse(Console.ReadLine());
        string[] safe = Console.ReadLine()
                       .Split(new char[] { ' ' }, 
                      StringSplitOptions
                      .RemoveEmptyEntries);

        bag = new Dictionary<string, Dictionary<string, long>>();

        FilterBagItems(input, safe);

        PrintOutput();
    }
    private static void FilterBagItems(long input, string[] safe)
    {
        for (int i = 0; i < safe.Length; i += 2)
        {
            string name = safe[i];
            long count = long.Parse(safe[i + 1]);

            string itemKind = SetItemType(name);

            if (itemKind == "")
            {
                continue;
            }
            else if (input < bag.Values.Select(x => x.Values.Sum()).Sum() + count)
            {
                continue;
            }

            switch (itemKind)
            {
                case "Gem":
                    if (!bag.ContainsKey(itemKind))
                    {
                        if (bag.ContainsKey("Gold"))
                        {
                            if (count > bag["Gold"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[itemKind].Values.Sum() + count > bag["Gold"].Values.Sum())
                    {
                        continue;
                    }
                    break;
                case "Cash":
                    if (!bag.ContainsKey(itemKind))
                    {
                        if (bag.ContainsKey("Gem"))
                        {
                            if (count > bag["Gem"].Values.Sum())
                            {
                                continue;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (bag[itemKind].Values.Sum() + count > bag["Gem"].Values.Sum())
                    {
                        continue;
                    }
                    break;
            }

            AddItemsToBag(itemKind, name, count);
        }
    }

    private static string SetItemType(string name)
    {
        string itemKind = string.Empty;

        if (name.Length == 3)
        {
            itemKind = "Cash";
        }
        else if (name.ToLower().EndsWith("gem"))
        {
            itemKind = "Gem";
        }
        else if (name.ToLower() == "gold")
        {
            itemKind = "Gold";
        }
        return itemKind;
    }

    private static void AddItemsToBag(string itemKind, string name, long count)
    {
        if (!bag.ContainsKey(itemKind))
        {
            bag[itemKind] = new Dictionary<string, long>();
        }

        if (!bag[itemKind].ContainsKey(name))
        {
            bag[itemKind][name] = 0;
        }

        bag[itemKind][name] += count;

        if (itemKind == "Gold")
        {
            gold += count;
        }
        else if (itemKind == "Gem")
        {
            gems += count;
        }
        else if (itemKind == "Cash")
        {
            cash += count;
        }
    }

    private static void PrintOutput()
    {
        foreach (var x in bag)
        {
            Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
            foreach (var keyValuePair in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
            {
                Console.WriteLine($"##{keyValuePair.Key} - {keyValuePair.Value}");
            }
        }
    }
}
