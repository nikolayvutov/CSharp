using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza = new Pizza();
        Dough dough;
        string pizzasName = "N";
        string input;
        try
        {
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split();
                string name = tokens[0];

                switch (name)
                {
                    case "Pizza":
                        string nameInput = tokens[1];
                        pizzasName = nameInput;
                        break;
                    case "Dough":
                        string flaur = tokens[1];
                        string bakingTechnique = tokens[2];
                        double grams = double.Parse(tokens[3]);
                        dough = new Dough(flaur, bakingTechnique, grams);
                        pizza = new Pizza(pizzasName, dough);
                        break;
                    case "Topping":
                        string type = tokens[1];
                        double weight = double.Parse(tokens[2]);
                        Topping topping = new Topping(type, weight);
                        pizza.AddTopping(topping);
                        break;
                }

            }

            Console.WriteLine(pizza.ToString());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

