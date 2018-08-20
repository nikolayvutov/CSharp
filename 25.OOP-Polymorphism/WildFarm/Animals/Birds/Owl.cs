using System;

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
    }

    public override void Eat(Food food)
    {
        var foodInput = food.GetType().ToString();

        if (foodInput != "Meat")
        {
            throw new ArgumentException($"{this.GetType()} does not eat {foodInput}!");
        }

        int pieces = food.Quantity;
        var result = pieces * 0.25;

        this.Weight += result;
        this.FoodEaten += pieces;
    }

    public override string SoundProduce()
    {
        return "Hoot Hoot";
    }
}
