using System;

public class Tomcat : Cat
{
    public Tomcat(string name, int age, string gender, string type)
        :base(name, age, gender, type)
    {
    }

    public override string Gender
    {
        get { return "Male"; }
    }

    public override string ProduceSound()
    {
        return "MEOW";
    }
}

