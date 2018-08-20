using System;
using System.Collections.Generic;

public class RandomList : List<string>
{
    private Random rnd;

    public RandomList()
    {
        this.rnd = new Random();
    }

    public string RandomString()
    {
        return "";
    }
}
