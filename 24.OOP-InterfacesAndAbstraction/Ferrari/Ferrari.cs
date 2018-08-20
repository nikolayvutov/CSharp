using System;

public class Ferrari : ICar
{
    public string Model { get; private set; }
    public string Driver { get; private set; }

    public Ferrari(string driver)
    {
        this.Driver = driver;
        this.Model = "488-Spider";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }
    public string Break()
    {
        return "Brakes!";   
    }

    public override string ToString()
    {
        return $"{this.Model}/{Break()}/{Gas()}/{this.Driver}";
    }
}

