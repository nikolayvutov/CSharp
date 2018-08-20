using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        string input;
        while ((input = Console.ReadLine()) != "Beast!")
        {
            try
            {
                var tokens = Console.ReadLine().Split();

                switch (input)
                {
                    case "Cat":
                        Cat cat = new Cat(tokens[0], int.Parse(tokens[1]), tokens[2], "Cat");
                        animals.Add(cat);
                        break;
                    case "Dog":
                        Dog dog = new Dog(tokens[0], int.Parse(tokens[1]), tokens[2], "Dog");
                        animals.Add(dog);
                        break;
                    case "Frog":
                        Frog frog = new Frog(tokens[0], int.Parse(tokens[1]), tokens[2], "Frog");
                        animals.Add(frog);
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(tokens[0], int.Parse(tokens[1]), tokens[2], "Kitten");
                        animals.Add(kitten);
                        break;
                    case "Tomcat":
                        Tomcat tomcat = new Tomcat(tokens[0], int.Parse(tokens[1]), tokens[2], "Tomcat");
                        animals.Add(tomcat);
                        break;
                    default:
                        throw new ArgumentException("Invalid input!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Type);
            Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
            Console.WriteLine(animal.ProduceSound());
        }
    }
}

