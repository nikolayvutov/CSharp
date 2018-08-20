using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = $"[^a-zA-Z]{Regex.Escape(Console.ReadLine())}[^a-zA-Z]";

        var input = Console.ReadLine().Split(new char[] { '.', '!', '?' },
                                             StringSplitOptions.RemoveEmptyEntries);

        Regex r = new Regex(pattern);

        foreach (var item in input)
        {
            Match match = r.Match(item);

            if (match.Success)
            {
                Console.WriteLine(item.Trim());
            }
        }
    }
}