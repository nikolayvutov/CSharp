using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var tokens = input.Split();
            Person person = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);
            people.Add(person);
        }
        int countPeople = people.Count();

        int indexPerson = int.Parse(Console.ReadLine());
        var comparePerson = people[indexPerson-1];

        var peopleCompare = people.Count(p => p.CompareTo(comparePerson) == 0);
        var peopleNotCompare = people.Count(p => p.CompareTo(comparePerson) != 0);

        if (peopleCompare == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{peopleCompare} {peopleNotCompare} {countPeople}");
        }
    }
}
