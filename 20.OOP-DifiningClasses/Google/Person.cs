using System;
using System.Collections.Generic;

public class Person
{
    public string Name;
    public Company Company;
    public List<Pokemon> Pokemon;
    public List<Parent> Parent;
    public List<Children> Children;
    public Car Car;

    public Person(string name)
    {
        this.Name = name;
        this.Car = null;
        this.Pokemon = new List<Pokemon>();
        this.Parent = new List<Parent>();
        this.Children = new List<Children>();
    }
}

