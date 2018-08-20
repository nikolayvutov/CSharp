using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = s => char.IsUpper(s[0]);

            Console.ReadLine().Split(new string[] {", "},
                                     StringSplitOptions
                                     .RemoveEmptyEntries)
                   .Select(double.Parse)
                   .Select(d => d*1.2)
                   .ToList()
                   .ForEach(d => Console.WriteLine($"{d:f2}"));
        }
    }
}
