using System;
using System.Collections.Generic;

public class Trainer
{
    public string Name;
    public int Badget;
    public List<Pokemon> Pokemons;

    public Trainer(string name)
    {
        this.Name = name;
        this.Badget = 0;
        this.Pokemons = new List<Pokemon>();
    }
}

