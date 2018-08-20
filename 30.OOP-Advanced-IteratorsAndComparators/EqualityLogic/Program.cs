using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        SortedSet<Person> peopleSet = new SortedSet<Person>();
        HashSet<Person> peopleHash = new HashSet<Person>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();
            Person person = new Person(tokens[0], int.Parse(tokens[1]));

            peopleSet.Add(person);
            if (!peopleHash.Any(p => p.Name == person.Name && p.Age == person.Age))
                peopleHash.Add(person);
        }

        Console.WriteLine(peopleSet.Count);

        var selected = peopleHash.Select(x => x.CompareTo(x) != 0);
        Console.WriteLine(selected.Count());
    }
}
