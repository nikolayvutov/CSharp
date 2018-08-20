using System;

public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion) 
        : base(name, weight, livingRegion)
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
        var result = pieces * 0.40;

        this.Weight += result;
        this.FoodEaten += pieces;
    }


    public override string SoundProduce()
    {
        return "Woof!";
    }
}

