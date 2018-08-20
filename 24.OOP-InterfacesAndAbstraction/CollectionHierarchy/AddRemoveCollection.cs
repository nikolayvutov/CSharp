using System;
using System.Collections.Generic;
using System.Linq;

public class AddRemoveCollection : IAddRemoveCollection
{
    public List<string> Collection { get; }

    public AddRemoveCollection()
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
        var lastElement = this.Collection.Last();
        this.Collection.Remove(lastElement);

        return lastElement;
    }
}

