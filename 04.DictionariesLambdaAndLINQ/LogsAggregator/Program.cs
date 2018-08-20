using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> users = new
                SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] log = Console.ReadLine().Split(new char[] { ' ' },
                                                        StringSplitOptions
                                                        .RemoveEmptyEntries);

                string username = log[1];
                string IP = log[0];
                int duration = int.Parse(log[2]);


                if (!users.ContainsKey(username))
                {
                    users.Add(username, new SortedDictionary<string, int>());
                }
                if (!users[username].ContainsKey(IP))
                {
                    users[username].Add(IP, duration);
                }
                else
                {
                    users[username][IP]+= duration;
                }

            }

            foreach (var user in users.OrderBy(x => x.Key))
            {
                var sum = user.Value.Values.Sum();


                Console.Write($"{user.Key}: {sum} ");
                Console.WriteLine($"[{string.Join(", ", user.Value.Keys)}]");
            }

        }
    }
}
