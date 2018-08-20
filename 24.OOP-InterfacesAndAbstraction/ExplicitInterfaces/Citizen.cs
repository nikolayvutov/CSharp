using System;

public class Citizen : IPerson, IResident
{
    public string Name
    {
        get;
        set;
    }

    public string Country
    {
        get;
        set;
    }

    public int Age
    {
        get;
        set;
    }

    public Citizen(string name, string country, int age)
    {
        this.Name = name;
        this.Country = country;
        this.Age = age;
    }

    public void GetName()
    {
        Console.WriteLine($"Mr/Ms/Mrs {this.Name}");
    }
}

