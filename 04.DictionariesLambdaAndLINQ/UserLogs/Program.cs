using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> users = new 
                Dictionary<string, Dictionary<string, int>>();


            while (input != "end")
            {
                string[] log = input.Split(new char[] { '=', ' ' },
                                           StringSplitOptions
                                           .RemoveEmptyEntries);

                string username = log[5];
                string IP = log[1];
                int count = 1;

                if (!users.ContainsKey(username))
                {
                    users.Add(username, new Dictionary<string, int>());
                }
                if (!users[username].ContainsKey(IP))
                {
                    users[username].Add(IP, count);
                }
                else
                {
                    users[username][IP]++;
                }

                input = Console.ReadLine();
            }

            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: ");
                foreach (var log in user.Value)
                {
                    if (log.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{log.Key} => {log.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{log.Key} => {log.Value}.");
                    }
                }
            }
        }
    }
}
