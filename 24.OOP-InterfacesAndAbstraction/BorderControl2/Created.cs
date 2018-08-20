using System;

public class Created : ICitizen, IRobot, IPet
{
    private string name;
    private int age;
    private string id;
    private string model;
    private string birthdate;


    public Created(string name, string birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }

    public Created(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public Created(string model, string id, int age = 0)
    {
        this.Model = model;
        this.Id = id;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Birthdate
    {
        get { return birthdate; }
        set { birthdate = value; }
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

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

}
