using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        DraftManager draft = new DraftManager();
        //draft.RegisterHarvester(new List<string>() { "Hammer", "CDD", "100", "50" });
        //draft.RegisterProvider(new List<string>() { "Solar", "DD", "100", "60" });
        //Console.WriteLine(draft.Check(new List<string>() { "CDD" }));
        //Console.WriteLine(draft.Check(new List<string>() {"DD"}));

        string input;
        while ((input = Console.ReadLine()) != "Shutdown")
        {
            var tokens = input.Split();

            var list = tokens.Skip(1).Take(tokens.Length).ToList();

            switch (tokens[0])
            {
                case "RegisterHarvester":
                    Console.WriteLine(draft.RegisterHarvester(list));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draft.RegisterProvider(list));
                    break;
                case "Check":
                    Console.WriteLine(draft.Check(list));
                    break;
                case "Day":
                    Console.WriteLine(draft.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draft.Mode(list));
                    break;
            }
        }

        Console.WriteLine(draft.ShutDown());
    }
}