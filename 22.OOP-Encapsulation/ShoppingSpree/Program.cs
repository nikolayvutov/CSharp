using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            for (int i = 0; i < peopleInput.Length; i++)
            {
                var tokens = peopleInput[i].Split('=', StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                double money = double.Parse(tokens[1]);
                Person person = new Person(name, money);
                people.Add(person);
            }

            var productsInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < productsInput.Length; i++)
            {
                var tokens = productsInput[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                double money = double.Parse(tokens[1]);

                Product product = new Product(name, money);
                products.Add(product);
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var name = people.First(p => p.Name == tokens[0]);
                var product = products.First(p => p.Name == tokens[1]);

                var output = name.BuyProduct(product);
                Console.WriteLine(output);
            }
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}

