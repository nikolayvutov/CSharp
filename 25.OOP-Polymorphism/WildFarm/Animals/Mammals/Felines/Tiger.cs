using System;

public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed) 
        : base(name, weight, livingRegion, breed)
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
        var result = pieces * 1.00;

        this.Weight += result;
        this.FoodEaten += pieces;
    }


    public override string SoundProduce()
    {
        return "ROAR!!!";
    }
}
