using System;

class Program
{
    static void Main(string[] args)
    {
        var first = Console.ReadLine().Split();
        var second = Console.ReadLine().Split();
        var third = Console.ReadLine().Split();

        var name = $"{first[0]} {first[1]}";
        bool Boolean = second[2] == "drunk" ? true : false;

        Tuple<string, string, string> tuple = new Tuple<string, string, string>(name, first[2], first[3]);

        Tuple<string, int, bool> tuple2 = new Tuple<string, int, bool>(second[0], int.Parse(second[1]), Boolean);

        Tuple<string, double, string> tuple3 = new Tuple<string, double, string>(third[0], double.Parse(third[1]), third[2]);

        Console.WriteLine(tuple.ToString());
        Console.WriteLine(tuple2.ToString());
        Console.WriteLine(tuple3.ToString());

    }
}

