using System;

public abstract class Feline : Mammal
{
    private string breed;

    public Feline(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }
    public override string ToString()
    {
        return $"{this.GetType()} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

