using System;

public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
        :base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
    {
    }

    public void DriveDistance(double distance)
    {
        var resultFuel = distance * (this.FuelConsumationPerKm + 0.9);
        if (resultFuel <= this.FuelQuantity)
        {
            this.DrivenDistance += distance;
            this.FuelQuantity -= resultFuel;

            Console.WriteLine($"Car travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"Car needs refueling");
        }
    }
}

