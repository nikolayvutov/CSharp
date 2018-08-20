using System;
using System.Collections;
using System.Collections.Generic;

public class Lake<T> : IEnumerable<T>
{
    private readonly List<T> list;

    public Lake(IEnumerable<T> collection)
    {
        list = new List<T>(collection);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < list.Count; i+= 2)
        {
            yield return this.list[i];
        }

        var lastOddIndex = this.list.Count % 2 == 0 ? this.list.Count - 1 :
                               this.list.Count - 2;

        for (int i = lastOddIndex; i >= 0; i-= 2)
        {
            yield return this.list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

