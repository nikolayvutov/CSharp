using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var carInput = Console.ReadLine().Split();
        var truckInput = Console.ReadLine().Split();
        var busInput = Console.ReadLine().Split();
        int n = int.Parse(Console.ReadLine());

        Car car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
        Truck truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));
        Bus bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var distance = double.Parse(input[2]);
            try
            {
                switch (input[0])
                {
                    case "Drive":
                        switch (input[1])
                        {
                            case "Car":
                                car.DriveDistance(distance);
                                break;
                            case "Truck":
                                truck.DriveDistance(distance);
                                break;
                            case "Bus":
                                bus.DriveDistance(distance);
                                break;
                        }
                        break;

                    case "DriveEmpty":
                        if (input[1] == "Bus")
                        {
                            bus.DriveEmpty(distance);
                        }
                        break;
                    case "Refuel":
                        var liters = double.Parse(input[2]);
                        switch (input[1])
                        {
                            case "Car":
                                car.Refuel(liters, distance, double.Parse(carInput[3]));
                                break;
                            case "Truck":
                                truck.Refuel(liters, distance, double.Parse(truckInput[3]));
                                break;
                            case "Bus":
                                bus.Refuel(liters, distance, double.Parse(busInput[3]));
                                break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine($"Car: {car.FuelQuantity:F2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");



    }
}
