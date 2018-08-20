using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Person[] person = new Person[n];

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            string name = input[0];
            int age = int.Parse(input[1]);

            person[i] = new Person(name, age);
        }

        List<Person> sortedPersons = person
            .OrderBy(x => x.Name)
            .Where(p => p.Age > 30)
            .ToList();


        foreach (Person p in sortedPersons)
        {
            Console.WriteLine($"{p.Name} - {p.Age}");
        }
    }
}

