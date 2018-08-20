using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private double money;
    private List<Product> bag;

    public string Name
    {
        get { return name; }
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value; 
        }
    }

    public double Money
    {
        get { return money; }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value; 
        }
    }

    public List<Product> Bag
    {
        get { return bag; }
        set { bag = value; }
    }

    public Person(string name, double money)
    {
        this.Name = name;
        this.Money = money;
        this.Bag = new List<Product>();
    }

    public string BuyProduct(Product product)
    {
        if (this.Money >= product.Cost)
        {
            this.Bag.Add(product);
            this.Money -= product.Cost;

            return $"{this.Name} bought {product.Name}";
        }
        else
        {
            return $"{this.Name} can't afford {product.Name}";
        }
    }

    public override string ToString()
    {
        string products = this.Bag.Count > 0 ? string.Join(", ", this.Bag) : "Nothing bought";

        string result = $"{this.Name} - {products}";
        return result;
    }
}

