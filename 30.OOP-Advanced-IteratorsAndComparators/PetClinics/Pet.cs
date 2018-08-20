using System;

public class Pet
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Kind { get; private set; }

    public Pet(string name, int age, string kind)
    {
        this.Name = name;
        this.Age = age;
        this.Kind = kind;
    }
}

