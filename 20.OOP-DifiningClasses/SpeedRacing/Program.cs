using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Car> cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string model = tokens[0];
            int fuel = int.Parse(tokens[1]);
            double consumation = double.Parse(tokens[2]);

            Car car = new Car(model, fuel, consumation);
            cars.Add(car);
        }

        string commandInput;
        while ((commandInput = Console.ReadLine()) != "End")
        {
            string[] tokens = commandInput.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string carModel = tokens[1];
            double miles = double.Parse(tokens[2]);

            cars.Where(c => c.Model == carModel)
                .ToList()
                .ForEach(c => c.DriveDistance(miles));
        }

        foreach (var c in cars)
        {
            Console.WriteLine($"{c.Model} {c.FuelAmout:f2} {c.DistanceTravelled}");
        }
    }
}

