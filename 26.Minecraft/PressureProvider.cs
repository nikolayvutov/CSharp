using System;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput)
        :base(id, energyOutput)
    {
        EnergyOutput += EnergyOutput * 0.5;
    }
}

