using System;

public abstract class Mammal : Animal
{
    private string livingRegion;

    public Mammal(string name, double weight, string livingRegion)
        :base(name, weight)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion
    {
        get { return this.livingRegion; }
        set { this.livingRegion = value; }
    }

    public override string ToString()
    {
        return $"{this.GetType()} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

