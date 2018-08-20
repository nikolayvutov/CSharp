using System;

public class Kitten : Cat
{
    public Kitten(string name, int age, string gender, string type)
        :base(name, age, gender, type)
    {
    }

    public override string Gender
    {
        get { return "Female"; }
    }

    public override string ProduceSound()
    {
        return "Meow";
    }
}

