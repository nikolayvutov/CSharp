using System;

public class Topping
{
    private string type;
    private double weight;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public double Weight
    {
        get { return weight; }
        set 
        { 
            if (1 > value || 50 < value)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
            }
            weight = value; 
        }
    }

    public Topping(string type, double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public double ToppingCalories()
    {
        double typeCal = 0;

        switch (type.ToLower())
        {
            case "meat":
                typeCal = 1.2;
                break;
            case "veggies":
                typeCal = 0.8;
                break;
            case "cheese":
                typeCal = 1.1;
                break;
            case "sauce":
                typeCal = 0.9;
                break;
            default:
                throw new ArgumentException($"Cannot place {this.Type} on top of your pizza.");
        }

        return (2 * weight) * typeCal;
    }
}

