using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            Person person = new Person(input[0], input[1], int.Parse(input[2]));
            people.Add(person);
        }

        people.OrderBy(p => p.FirstName)
              .ThenBy(p => p.Age)
              .ToList()
              .ForEach(p => Console.WriteLine(p.ToString()));
       
    }
}
