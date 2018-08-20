using System;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion)
        :base(name, weight, livingRegion)
    {
    }

    public override void Eat(Food food)
    {
        var foodInput = food.GetType().ToString();

        if ( foodInput != "Vegetable" && foodInput != "Fruit")
        {
            throw new ArgumentException($"{this.GetType()} does not eat {foodInput}!");
        }

        int pieces = food.Quantity;
        var result = pieces * 0.10;

        this.Weight += result;
        this.FoodEaten += pieces;
    }

    public override string SoundProduce()
    {
        return "Squeak";
    }
}
