using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FixEmails
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string name = Console.ReadLine();

            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (name != "stop")
            {
                string mail = Console.ReadLine();

                if (!(mail.EndsWith("uk") || mail.EndsWith("us")))
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, mail);
                    }
                    else
                    {
                        dict[name] = mail;
                    }

                }

                name = Console.ReadLine();
            }

            foreach (var x in dict)
            {
                Console.WriteLine($"{x.Key} -> {x.Value}");
            }
        }
    }
}
