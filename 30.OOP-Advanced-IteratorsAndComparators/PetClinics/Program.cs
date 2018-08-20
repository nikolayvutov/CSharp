using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Pet> pets = new List<Pet>();
        List<Clinic> clinics = new List<Clinic>();

        while (n-- > 0)
        {
            var tokens = Console.ReadLine().Split();

            switch (tokens[0])
            {
                case "Create":
                    if (tokens[1] == "Pet")
                    {
                        Pet pet = new Pet(tokens[2], int.Parse(tokens[3]), tokens[4]);
                        pets.Add(pet);
                    }
                    else
                    {
                        Clinic clinic = new Clinic(tokens[2], int.Parse(tokens[3]));
                        clinics.Add(clinic);
                    }
                    break;
                case "HasEmptyRooms":
                    
                    break;
                case "Add":
                    
                    break;
                case "Print":
                    break;
                case "Release":
                    break;
            }
        }
    }
}
