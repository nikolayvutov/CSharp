using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Citizen> list = new List<Citizen>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            Citizen citizen = new Citizen(tokens[0], tokens[1], int.Parse(tokens[2]));
            list.Add(citizen);

        }

        foreach (var person in list)
        {
            Console.WriteLine(person.Name);
            person.GetName();
        }
    }
}

