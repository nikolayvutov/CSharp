using System;

public interface ICitizen : INameble
{
    int Age { get; }
    string Id { get; }
    string Birthdate { get; }
}

