using System;

public class Box<T>
{
    public Box()
    {
        this.Value = default(T);
    }

    public Box(T value)
    {
        this.Value = value;
    }

    public T Value { get; private set; }

    public override string ToString()
	{
        return $"{typeof(T).FullName}: {this.Value}";
	}
}
