using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Car[] cars = new Car[lines];

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split();
                string model = input[0];
                double speed = double.Parse(input[1]);
                double power = double.Parse(input[2]);
                double weight = double.Parse(input[3]);
                string type = input[4];
                double tyre1Pressure = double.Parse(input[5]);
                int tyre1Age = int.Parse(input[6]);
                double tyre2Pressure = double.Parse(input[7]);
                int tyre2Age = int.Parse(input[8]);
                double tyre3Pressure = double.Parse(input[9]);
                int tyre3Age = int.Parse(input[10]);
                double tyre4Pressure = double.Parse(input[11]);
                int tyre4Age = int.Parse(input[12]);

                cars[i] = new Car(model,
                          new Engine(speed, power),
                          new Cargo(type, weight),
                          new List<Tire>
                {
                    new Tire(tyre1Pressure, tyre1Age),
                    new Tire(tyre2Pressure, tyre2Age),
                    new Tire(tyre3Pressure, tyre3Age),
                    new Tire(tyre4Pressure, tyre4Age)
                });
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                var outputCars = cars.Where(c => c.cargo.Type == "fragile")
                    .Where(c => c.tires.Any(t => t.tirePressure < 1))
                    .Select(c => c.model).ToList();

                foreach (var c in outputCars)
                {
                    Console.WriteLine(c);
                }

            }
            else if (command == "flamable")
            {
                var outputCars = cars.Where(c => c.cargo.Type == "flamable")
                    .Where(c => c.engine.Power > 250)
                    .Select(c => c.model).ToList();

                foreach (var c in outputCars)
                {
                    Console.WriteLine(c);
                }
            }
        }
    }
}
