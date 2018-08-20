using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Stack<T> : IEnumerable<T>
{
    private readonly List<T> stack;

    public Stack()
    {
        stack = new List<T>();
    }

    public void Pop()
    {
        if (stack.Count == 0)
        {
            throw new ArgumentException("No elements");
        }
        var last = stack[stack.Count-1];
        stack.RemoveAt(stack.Count-1);
    }

    public void Push(IEnumerable<T> elements)
    {
        stack.AddRange(elements);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.stack.Count - 1; i >= 0; i--)
        {
            yield return this.stack[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

	public override string ToString()
	{
        StringBuilder sb = new StringBuilder();

        for (int i = stack.Count - 1; i >= 0; i--)
        {
            sb.AppendLine(stack[i].ToString());
        }
        return sb.ToString().Trim();
    }
}

