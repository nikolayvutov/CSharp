using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SerbianUnleashed
{
    class MainClass
    {
        public static void Main()
        {
            string input = Console.ReadLine();


            Dictionary<string, Dictionary<string, int>> dict = new
                Dictionary<string, Dictionary<string, int>>();


            while (input != "End")
            {
                string correctInput = @"(([a-zA-Z]+\s){1,3})@(([a-zA-Z]+\s){1,3})(\d+)\s(\d+)";

                if (Regex.IsMatch(input, correctInput))
                {
                    Match match = Regex.Match(input, correctInput);

                    string singer = match.Groups[1].Value.Trim();
                    string venue = match.Groups[3].Value.Trim();
                    int ticketsPrice = int.Parse(match.Groups[5].Value);
                    int ticketsCount = int.Parse(match.Groups[6].Value);

                    int totalMoney = ticketsCount * ticketsPrice;


                    if (!dict.ContainsKey(venue))
                    {
                        dict.Add(venue, new Dictionary<string, int>() { {singer, totalMoney} });
                    }
                    else if (!dict[venue].ContainsKey(singer))
                    {
                        dict[venue].Add(singer, totalMoney);
                    }
                    else
                    {
                        dict[venue][singer] += totalMoney;
                    }

                }

                input = Console.ReadLine();
            
            }

            foreach (var stage in dict)
            {
                Console.WriteLine(stage.Key);
                foreach (var artist in stage.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {artist.Key} -> {artist.Value}");
                }
            }


        }
    }
}
