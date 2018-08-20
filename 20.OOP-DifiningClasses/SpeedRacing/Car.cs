using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private double distanceTravelled;

    public double DistanceTravelled
    {
        get { return distanceTravelled; }
        set { distanceTravelled = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public double FuelAmout
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }

    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    public Car(string model, int fuel, double consumation)
    {
        this.Model = model;
        this.FuelAmout = fuel;
        this.FuelConsumption = consumation;
        this.distanceTravelled = 0;
    }

    public Car()
    {
        
    }

    public void DriveDistance(double distance)
    {
        if (this.FuelAmout < distance * this.FuelConsumption)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.FuelAmout -= distance * this.FuelConsumption;
            this.DistanceTravelled += distance;
        }
    }
}
