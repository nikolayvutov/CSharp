using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        List<IBuyer> list = new List<IBuyer>();
      
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            if (input.Length == 4)
            {
                Citizen citizen = new Citizen(input[0],
                                              int.Parse(input[1]),
                                              input[2],
                                              input[3]);
                list.Add(citizen);
            }
            else
            {
                Rebel rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                list.Add(rebel);
            }
        }

        string name;
        while ((name = Console.ReadLine()) != "End")
        {
            var human = list.FirstOrDefault(l => l.Name == name);

            if (human != null)
            {
                human.BuyFood();
            }
        }

        var sum = list.Sum(b => b.Food);
        Console.WriteLine(sum);
    }
}

