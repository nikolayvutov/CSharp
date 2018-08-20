using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        List<Created> list = new List<Created>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length == 5)
            {
                var citizen = new Created(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]);
                list.Add(citizen);
            }
            else if(tokens.Length == 3)
            {
                if (tokens[0] == "Pet")
                {
                    var pet = new Created(tokens[1], tokens[2]);
                    list.Add(pet);
                }

            }
        }
        string num = Console.ReadLine().Trim();

        foreach (var item in list.Where(c => c.Birthdate.EndsWith(num)))
        {
            Console.WriteLine(item.Birthdate);  
        }
    }
}

