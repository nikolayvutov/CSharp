using System;

public class Citizen : ICitizen, IBuyer
{
    private string name;
    private int age;
    private string id;
    private string birthdate;
    private int food;

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Food
    {
        get { return food; }
        set { food = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Birthdate
    {
        get { return birthdate; }
        set { birthdate = value; }
    }

    public void BuyFood()
    {
        this.Food += 10;
    }
}

