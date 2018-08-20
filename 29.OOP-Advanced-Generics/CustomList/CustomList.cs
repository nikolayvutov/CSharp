using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CustomList<T> : ICustomList<T>, IEnumerable<T>
    where T : IComparable<T>
{
    private readonly IList<T> elements;

    public CustomList()
        : this(Enumerable.Empty<T>())
    {
    }

    public CustomList(IEnumerable<T> collection)
    {
        this.elements = new List<T>(collection);
    }

    public IList<T> Elements => elements;

    public void Add(T element)
    {
        this.elements.Add(element);
    }

    public bool Contains(T element)
    {
        return this.elements.Contains(element);
    }

    public int CountGreaterThan(T element)
    {
        return elements.Count(e => e.CompareTo(element) > 0);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return elements.GetEnumerator();
    }

    public T Max()
    {
        return elements.Max();
    }

    public T Min()
    {
        return elements.Min();
    }

    public T Remove(int index)
    {
        T temp = this.elements[index];
        this.elements.RemoveAt(index);

        return temp;
    }

    public void Swap(int index1, int index2)
    {
        var tempElement = elements[index1];
        elements[index1] = elements[index2];
        elements[index2] = tempElement;
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, this.elements);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return elements.GetEnumerator();
    }
}
