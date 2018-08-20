using System;
using System.Collections.Generic;

public class Tuple<T, T1, T2>
{
    public Tuple(T name, T1 value, T2 secondValue)
    {
        this.Name = name;
        this.Value = value;
        this.SecondValue = secondValue;
    }

    public T Name { get; private set; }
    public T1 Value { get; private set; }
    public T2 SecondValue { get; private set; }

    public override string ToString()
    {
        return $"{this.Name} -> {this.Value} -> {this.SecondValue}";
    }
}
