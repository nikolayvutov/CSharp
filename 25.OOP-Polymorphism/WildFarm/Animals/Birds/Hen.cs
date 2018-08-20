using System;

public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
    }

    public override void Eat(Food food)
    {
        int pieces = food.Quantity;
        var result = pieces * 0.35;

        this.Weight += result;
        this.FoodEaten += pieces;
    }

    public override string SoundProduce()
    {
        return "Cluck";
    }

}

