using System;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;

    public string FlourType
    {
        get { return flourType; }
        set 
        {
            if (value != "white" || value != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            flourType = value; 
        }
    }

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set 
        { 
            if (value != "crispy" || value != "chewy" || value != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value; 
        }
    }

    public double Weight
    {
        get { return weight; }
        set 
        {
            if (1 > value || value > 200)
            {
                throw new ArgumentException($"{FlourType} weight should be in the range [1..200].");
            }
            weight = value; 
        }
    }


    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public double DoughCalories()
    {
        double typeCals = 0;
        double bakingCals = 0;

        switch (FlourType.ToLower())
        {
            case "white":
                typeCals = 1.5;
                break;
            case "wholegrain":
                typeCals = 1.0;
                break;
            default:
                throw new ArgumentException("Invalid type of dough.");
        }

        switch (BakingTechnique.ToLower())
        {
            case "crispy":
                bakingCals = 0.9;
                break;
            case "chewy":
                bakingCals = 1.1;
                break;
            case "homemade":
                bakingCals = 1.0;
                break;
            default:
                throw new ArgumentException("Invalid type of dough.");
        }
      
        return (2 * weight) * typeCals * bakingCals;
    }
}

