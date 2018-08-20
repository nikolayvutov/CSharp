using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> topping;


    public string Name
    {
        get { return name; }
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            name = value; 
        }
    }

    public Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }

    public int GetNumberOfToppings()
    {
        return this.topping.Count;
    }

    public List<Topping> Topping
    {
        get { return topping; }
        set 
        { 
            if (value.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            topping = value; 
        }
    }

    public Pizza()
    {
        this.Topping = new List<Topping>();
    }

    public Pizza(string name, Dough dough)
    {
        this.Name = name;
        this.Dough = dough;
        this.Topping = new List<Topping>();
    }
    public void AddTopping(Topping topping)
    {
        if (this.topping.Count == 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
        this.topping.Add(topping);
    }


    public double TotalCalories()
    {
        var doughtCals = dough.DoughCalories();
        var toppingCals = topping.Select(t => t.ToppingCalories()).Sum();
        var result = doughtCals + toppingCals;
        return result;
    }

    public override string ToString()
    {
        return $"{this.Name} - {TotalCalories():f2} Calories.";
    }
}

