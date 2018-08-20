using System;
using System.Collections.Generic;
using System.Linq;

public class DraftManager
{
    private List<Harvester> harvesters = new List<Harvester>();
    private List<Provider> providers = new List<Provider>();


    public DraftManager()
    {
        harvesters = new List<Harvester>();
        providers = new List<Provider>();
        this.totalOre = 0;
        this.allEnergy = 0;
        this.mode = "Full";
    }



    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            if (arguments[0] == "Sonic")
            {
                SonicHarvester sH = new SonicHarvester(arguments[1],
                                           double.Parse(arguments[2]),
                                           double.Parse(arguments[3]),
                                           int.Parse(arguments[4]));
                harvesters.Add(sH);
            }

            else if (arguments[0] == "Hammer")
            {
                HammerHarvester hH = new HammerHarvester(arguments[1],
                                           double.Parse(arguments[2]),
                                           double.Parse(arguments[3]));

                harvesters.Add(hH);
            }
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }

        return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            if (arguments[0] == "Solar")
            {
                SolarProvider sP = new SolarProvider(arguments[1],
                                                     double.Parse(arguments[2]));

                providers.Add(sP);
            }

            else if (arguments[0] == "Pressure")
            {
                PressureProvider pP = new PressureProvider(arguments[1],
                                                     double.Parse(arguments[2]));
                providers.Add(pP);
            }
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }

        return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";

    }
    double allEnergy = 0;
    double totalOre = 0;

    string mode = "Full";

    public string Day()
    {
        double dayOre = 0;
        double harvestEnergy = 0;
        double dayEnergy = providers.Sum(x => x.EnergyOutput);

        allEnergy += dayEnergy;
        harvestEnergy = harvesters.Sum(x => x.EnergyRequirement);

        if (allEnergy >= harvestEnergy)
        {
            if (mode == "Full")
            {
                dayOre = harvesters.Sum(x => x.OreOutput);
                allEnergy -= harvestEnergy;
            }
            else if (mode == "Half")
            {
                dayOre = harvesters.Sum(x => x.OreOutput * 0.5);
                allEnergy -= harvestEnergy * 0.6;
            }
            totalOre += dayOre; 
        }

        return $"A day has passed." + Environment.NewLine + 
             $"Energy Provided: {dayEnergy}" + Environment.NewLine +
              $"Plumbus Ore Mined: {dayOre}";
    }

    public string Mode(List<string> arguments)
    {
        mode = arguments[0];

        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var hasProvider = providers.Any(p => p.Id == arguments[0]);
        var hasHarvest = harvesters.Any(p => p.Id == arguments[0]);

        if (hasHarvest)
        {
            Harvester harvester = harvesters.First(h => h.Id == arguments[0]);
            var type = harvester.GetType().Name;
            return $"{type.Substring(0, type.Length - 9)} Harvester - {harvester.Id}" + Environment.NewLine +
                 $"Ore Output: {harvester.OreOutput}" + Environment.NewLine +
                 $"Energy Requirement: {harvester.EnergyRequirement}";
        }
        else if (hasProvider)
        {
            Provider provider = providers.First(p => p.Id == arguments[0]);
            var type = provider.GetType().Name;
                              return $"{type.Substring(0, type.Length - 8)} Provider - {provider.Id}" + 
                Environment.NewLine +
                           $"Energy Output: {provider.EnergyOutput}";
        }

        return $"No element found with id - {arguments[0]}";
    }

    public string ShutDown()
    {
        return "System Shutdown" + Environment.NewLine +
              $"Total Energy Stored: {allEnergy}" + Environment.NewLine +
              $"Total Mined Plumbus Ore: {totalOre}";

    }
}
