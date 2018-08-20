using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        ListyIterator<string> listyIterator;

        var input = Console.ReadLine();
        var tokens = input.Split();

        if (tokens.Length > 1)
        {
            listyIterator = new ListyIterator<string>(tokens.Skip(1));
        }
        else
        {
            listyIterator = new ListyIterator<string>();
        }

        while (input != "END")
        {
            tokens = input.Split();

            try
            {
                switch (tokens[0])
                {
                    case "Print":
                        Console.WriteLine(listyIterator.Print());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "PrintAll":
                        Console.WriteLine(listyIterator.PrintAll());
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            input = Console.ReadLine();
        }
    }
}
