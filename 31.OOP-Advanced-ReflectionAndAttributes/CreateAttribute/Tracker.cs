using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public static void PrintMethodsByAuthor()
    {
        var type = typeof(Program);
        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public
                                      | BindingFlags.Static);

        foreach (var method in methods)
        {
            if (method.CustomAttributes.Any(n => n.AttributeType == typeof(SoftUniAttribute)))
            {
                var attrs = method.GetCustomAttributes(false);
                foreach (SoftUniAttribute attr in attrs)
                {
                    Console.WriteLine($"{method.Name} is written by {attr.Name}");
                }
            }
        }
    }
}