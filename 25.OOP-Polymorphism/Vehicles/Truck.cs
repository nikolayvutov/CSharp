using System;

public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
        :base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
    {
    }

    public void DriveDistance(double distance)
    {
        var resultFuel = distance * (this.FuelConsumationPerKm + 1.6);
        if (resultFuel <= this.FuelQuantity)
        {
            this.DrivenDistance += distance;
            this.FuelQuantity -= resultFuel;

            Console.WriteLine($"Truck travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"Truck needs refueling");
        }
    }

    public override void Refuel(double fuel, double distance, double capacity)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        if (fuel > capacity)
        {
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
        }
        var litters = fuel * 95 / 100;
        this.FuelQuantity += litters;
    }
}
