using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    class MainClass
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                                  .Split(new char[] { ' ' },
                                         StringSplitOptions.RemoveEmptyEntries)
                                  .Select(long.Parse).ToList();

            var hornets = Console.ReadLine()
                                  .Split(new char[] { ' ' },
                                         StringSplitOptions.RemoveEmptyEntries)
                                  .Select(long.Parse).ToList();

            List<long> aliveBeehive = new List<long>();

            foreach (var beehive in beehives)
            {
                if (hornets.Count == 0)
                {
                    aliveBeehive.Add(beehive);
                    continue;
                }
                var power = hornets.Sum();

                if (power >= beehive)
                {
                    if (power == beehive)
                    {
                        hornets.RemoveAt(0);
                    }
                }
                else
                {
                    aliveBeehive.Add(beehive - power);
                    hornets.RemoveAt(0);
                }
            }

            if (aliveBeehive.Count != 0)
            {
                Console.WriteLine(string.Join(" ", aliveBeehive));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
