using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = s => char.IsUpper(s[0]);

            Console.WriteLine(string.Join(Environment.NewLine, 
            Console.ReadLine().Split(new string[] { " " },
                                     StringSplitOptions
                             .RemoveEmptyEntries).Where(checker)
                              .ToList()));
            
        }
    }
}
