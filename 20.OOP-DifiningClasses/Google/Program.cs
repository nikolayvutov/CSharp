using System;
using System.Collections.Generic;
using System.Linq;

class Google
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(new[] { ' ' },
                                     StringSplitOptions.RemoveEmptyEntries);

            FillPerson(tokens, people);
        }

        string printName = Console.ReadLine();
        PrintOutput(people, printName);
    }

    private static void FillPerson(string[] tokens, List<Person> people)
    {
        string name = tokens[0];

        if (!people.Any(p => p.Name == name))
        {
            people.Add(new Person(name));
        }

        Person person = people.Where(p => p.Name == name).First();

        switch (tokens[1])
        {
            case "company":
                string compName = tokens[2];
                string department = tokens[3];
                decimal salary = decimal.Parse(tokens[4]);
                person.Company = new Company(compName, department, salary);
                break;
            case "pokemon":
                string pokemonName = tokens[2];
                string type = tokens[3];
                person.Pokemon.Add(new Pokemon(pokemonName, type));
                break;
            case "parents":
                string parentName = tokens[2];
                string birthday = tokens[3];
                person.Parent.Add(new Parent(parentName, birthday));
                break;
            case "children":
                string childrenName = tokens[2];
                string childBirthday = tokens[3];
                person.Children.Add(new Children(childrenName, childBirthday));
                break;
            case "car":
                string model = tokens[2];
                int speed = int.Parse(tokens[3]);
                person.Car = new Car(model, speed);
                break;
        }
    }

    private static void PrintOutput(List<Person> people, string printName)
    {
        Person per = people.Where(p => p.Name == printName).First();

        Console.WriteLine(per.Name);
        Console.WriteLine("Company:");
        if (per.Company != null)
        {
            Console.WriteLine($"{per.Company.Name} {per.Company.Department} {per.Company.Salary:f2}");
        }
        Console.WriteLine("Car:");
        if (per.Car != null)
        {
            Console.WriteLine($"{per.Car.Model} {per.Car.Speed}");
        }
        Console.WriteLine("Pokemon:");
        foreach (var poke in per.Pokemon)
        {
            Console.WriteLine($"{poke.Name} {poke.Type}");
        }
        Console.WriteLine("Parents:");
        foreach (var parent in per.Parent)
        {
            Console.WriteLine($"{parent.Name} {parent.Birthday}");
        }
        Console.WriteLine("Children:");
        foreach (var child in per.Children)
        {
            Console.WriteLine($"{child.Name} {child.Birthday}");
        }

    }
}