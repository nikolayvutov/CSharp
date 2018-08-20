using System;

public interface ICar
{
    string Model { get; }
    string Driver { get; }
    string Gas();
    string Break();
}
