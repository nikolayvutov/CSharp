using System.Collections.Generic;

public interface IAddCollection
{
    List<string> Collection { get; }

    string Add(string item);
}

