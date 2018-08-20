using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var peopleByName = new SortedSet<Person>(new NameComparator());
        var peopleByAge = new SortedSet<Person>(new AgeComparator());

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();
            Person person = new Person(tokens[0], int.Parse(tokens[1]));
            peopleByName.Add(person);
            peopleByAge.Add(person);
        }

        foreach (var person in peopleByName)
        {
            Console.WriteLine(person.ToString());
        }

        foreach (var person in peopleByAge)
        {
            Console.WriteLine(person.ToString());
        }
    }
}
