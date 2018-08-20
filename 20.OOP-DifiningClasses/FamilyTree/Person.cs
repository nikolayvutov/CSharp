using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private string birthDay;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {
        this.Children = new List<Person>();
        this.Parents = new List<Person>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string BirthDay
    {
        get { return birthDay; }
        set { birthDay = value; }
    }

    public List<Person> Parents
    {
        get { return parents; }
        set { parents = value; }
    }

    public List<Person> Children
    {
        get { return children; }
        set { children = value; }
    }

    public override string ToString()
    {
        return string.Format($"{this.Name} {this.BirthDay}");
    }
}

