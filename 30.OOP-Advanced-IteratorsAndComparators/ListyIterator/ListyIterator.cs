using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IEnumerable<T>
{
    private readonly List<T> list;
    private int currentIndex;

    public ListyIterator()
    {
        list = new List<T>();
        currentIndex = 0;
    }

    public ListyIterator(IEnumerable<T> collection)
    {
        this.list = new List<T>(collection);
    }

    public bool Move()
    {
        if (this.currentIndex< this.list.Count - 1)
        {
            this.currentIndex++;
            return true;
        }
        return false;
    }

    public bool HasNext() => this.currentIndex < this.list.Count-1;

    public T Print()
    {
        if (this.list.Count == 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }
        return this.list[this.currentIndex];
    }

    public string PrintAll() => string.Join(" ", this.list);

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.list.Count; i++)
        {
            yield return this.list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}
