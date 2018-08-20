using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

class Program
{
    

    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var animalInput = input.Split();
            var foodInput = Console.ReadLine().Split();
            var quantity = int.Parse(foodInput[1]);
            Animal animal = SetAnimal(animalInput);
            Console.WriteLine(animal.SoundProduce());

            try
            {
                Food food;
                switch (foodInput[0])
                {
                    case "Vegetable":
                        food = new Vegetable(quantity);
                        animal.Eat(food);
                        break;
                    case "Fruit":
                        food = new Fruit(quantity);
                        animal.Eat(food);
                        break;
                    case "Meat":
                        food = new Meat(quantity);
                        animal.Eat(food);
                        break;
                    case "Seeds":
                        food = new Seeds(quantity);
                        animal.Eat(food);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            animals.Add(animal);
        }

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }

    private static Animal SetAnimal(string[] animalInput)
    {
        var name = animalInput[1];
        var weight = double.Parse(animalInput[2]);

        Animal animal;
        switch (animalInput[0])
        {
            case "Owl":
                var wingSize = double.Parse(animalInput[3]);

                return animal = new Owl(name, weight, wingSize);
              
            case "Hen":
                wingSize = double.Parse(animalInput[3]);

                return animal = new Hen(name, weight, wingSize);
            
            case "Mouse":
                var livingRegion = animalInput[3];

                return animal = new Mouse(name, weight, livingRegion);
               
            case "Dog":
                livingRegion = animalInput[3];

                return animal = new Dog(name, weight, livingRegion);
              
            case "Cat":
                livingRegion = animalInput[3];
                var breed = animalInput[4];

                return animal = new Cat(name, weight, livingRegion, breed);
               
            case "Tiger":
                livingRegion = animalInput[3];
                breed = animalInput[4];

                return animal = new Tiger(name, weight, livingRegion, breed);

            default:
                throw new ArgumentException("Wrong Animal!");
        }
    }
}
