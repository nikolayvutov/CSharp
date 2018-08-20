using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        IList<Box<double>> list = new List<Box<double>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Box<double> boxStr = new Box<double>(double.Parse(Console.ReadLine()));
            list.Add(boxStr);
        }

        var element = double.Parse(Console.ReadLine());
        var result = GetGreaterElementsCout(list, element);

        Console.WriteLine(result);
    }

    private static int GetGreaterElementsCout<T>(IList<Box<T>> list, T element)
        where T : IComparable<T>
    {
        return list.Count(b => b.Value.CompareTo(element) > 0);
    }

}
