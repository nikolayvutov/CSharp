using System;
using System.Collections.Generic;

public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int firstPerson = x.Name.Length;
        int secondPerson = y.Name.Length;

        int result = firstPerson.CompareTo(secondPerson);

        var xName = x.Name.ToLower();
        var yName = y.Name.ToLower();

        if (result == 0)
            result = xName[0].CompareTo(yName[0]);

        return result;
    }
}
