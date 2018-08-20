using System;

public class Vehicle : IVehicle
{
    private double fuelQuantity;
    private double fuelConsumationPerKm;
    private double drivenDistance;
    private double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumationPerKm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumationPerKm = fuelConsumationPerKm;
    }

    public double TankCapacity
    {
        get { return this.tankCapacity; }
        set
        {
            this.tankCapacity = value;
        }
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set 
        { 
            if (value > this.tankCapacity)
            {
                this.fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = value; 
            }
        }
    }

    public double FuelConsumationPerKm
    {
        get { return this.fuelConsumationPerKm; }
        set { this.fuelConsumationPerKm = value; }
    }

    public double DrivenDistance
    {
        get { return this.drivenDistance; }
        set { this.drivenDistance = value; }
    }

    public void AddFuel(double fuel)
    {
        if (fuel + this.FuelQuantity <= this.TankCapacity)
        {
            this.FuelQuantity += fuel;
        }
    }

    public virtual void Refuel(double fuel, double distance, double capacity)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if (fuel > capacity)
        {
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
        }
        this.AddFuel(fuel);
    }


    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
    }
}
