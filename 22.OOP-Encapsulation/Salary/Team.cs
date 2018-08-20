using System;
using System.Collections.Generic;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public List<Person> FirstTeam
    {
        get {return this.firstTeam}
    }

    public Team()
    {
    }
}

