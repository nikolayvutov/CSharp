using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var firstDate = DateTime.Parse(Console.ReadLine());
        var secondDate = DateTime.Parse(Console.ReadLine());

        DateModifier date = new DateModifier();
        var result = date.CalculateDifference(firstDate, secondDate);

        Console.WriteLine(result);
    }
}

