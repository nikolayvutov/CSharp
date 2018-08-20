using System;

public interface IVehicle
{
    double FuelQuantity { get; }
    double FuelConsumationPerKm { get; }
    double DrivenDistance { get; }
    double TankCapacity { get; }
}
