using System;

public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
        :base(fuelQuantity, fuelConsumationPerKm, tankCapacity)
    {
    }

    public void DriveDistance(double distance)
    {
        var resultFuel = distance * (this.FuelConsumationPerKm + 1.4);
        if (resultFuel <= this.FuelQuantity)
        {
            this.DrivenDistance += distance;
            this.FuelQuantity -= resultFuel;

            Console.WriteLine($"Bus travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"Bus needs refueling");
        }
    }

    public void DriveEmpty(double distance)
    {
        var resultFuel = distance * this.FuelConsumationPerKm;
        if (resultFuel <= this.FuelQuantity)
        {
            this.DrivenDistance += distance;
            this.FuelQuantity -= resultFuel;
            Console.WriteLine($"Bus travelled {distance} km");
        }
        else
        {
            Console.WriteLine("Bus needs refueling");
        }
    }
}
