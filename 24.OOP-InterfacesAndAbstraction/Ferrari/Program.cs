using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();

        var ferrari = new Ferrari(input);
        Console.WriteLine(ferrari.ToString());
    }
}
