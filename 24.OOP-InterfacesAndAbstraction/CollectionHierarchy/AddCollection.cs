using System;
using System.Collections.Generic;

public class AddCollection : IAddCollection
{
    public List<string> Collection { get; }

    public AddCollection()
    {
        this.Collection = new List<string>();
    }

    public string Add(string item)
    {
        this.Collection.Add(item);

        return (this.Collection.Count - 1).ToString();
    }
}

