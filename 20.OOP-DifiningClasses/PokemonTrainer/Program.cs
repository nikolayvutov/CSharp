using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Trainer> trainers = new List<Trainer>();
        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            var tokens = input.Split(new[] { ' ' },
                                                  StringSplitOptions
                                                  .RemoveEmptyEntries);
            string trainerName = tokens[0];
            string pokemonName = tokens[1];
            string pokemonElement = tokens[2];
            int pokemonHealth = int.Parse(tokens[3]);

            if (!trainers.Any(t => t.Name == trainerName))
            {
                trainers.Add(new Trainer(trainerName));
            }

            var trainer = trainers.First(t => t.Name == trainerName);
            trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
        }

        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == input))
                {
                    trainer.Badget++;
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                    trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
                }
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.Badget))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badget} {trainer.Pokemons.Count}");
        }
    }
}
