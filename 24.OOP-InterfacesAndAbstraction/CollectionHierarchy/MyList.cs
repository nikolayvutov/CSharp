using System;
using System.Collections.Generic;
using System.Linq;

public class MyList : IMyList
{
    public List<string> Collection { get; }

    public MyList()
    {
        this.Collection = new List<string>();
    }

    public string Add(string item)
    {
        this.Collection.Insert(0, item);

        return "0";
    }

    public string Remove()
    {
        var firstElement = this.Collection.First();
        this.Collection.Remove(firstElement);

        return firstElement;
    }

    public int Used()
    {
        return this.Collection.Count;
    }
}

