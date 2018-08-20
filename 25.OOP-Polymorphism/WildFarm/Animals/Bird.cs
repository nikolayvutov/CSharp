using System;

public abstract class Bird : Animal
{
    private double wingSize;

    public Bird(string name, double weight, double wingSize)
        :base(name, weight)
    {
        this.WingSize = wingSize;
    }

    public double WingSize
    {
        get { return this.wingSize; }
        set { this.wingSize = value; }
    }

    public override string ToString()
    {
        return $"{this.GetType()} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}

