using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Weather
{
    public string City
    {
        get;
        set;
    }
    public double Temperature
    {
        get;
        set;
    }
    public string Type
    {
        get;
        set;
    }
}


public class Example
{
    public static void Main()
    {
        Weather weather = new Weather();

        string pattern = @"([A-Z]{2})([0-9]+\.[0-9]+)([A-Za-z]+)";
        string input = Console.ReadLine();
        int count = 0;
        List<Weather> weathers = new List<Weather>();
        while (input != "end")
        {

            foreach (Match m in Regex.Matches(input, pattern))
            {
                var city = m.Groups[1].Value;
                var tempeture = m.Groups[2].Value;
                var type = m.Groups[3].Value;

                weather.City = city;
                weather.Temperature = double.Parse(tempeture);
                weather.Type = type;
                weathers.Add(weather);
                count++;
            }

            input = Console.ReadLine();
        }

        weathers = weathers.OrderBy(w => w.Temperature).ToList();

        foreach (var w in weathers)
        {
            Console.WriteLine($"{w.City} => {w.Temperature:F2} => {w.Type}");
        }
    }
}