using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortWordsSorted
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] array = Console.ReadLine().ToLower()
                                    .Split(new char[] { ' ','.',',',':',';',
                '(',')','[',']','\'','"','\\','/','!','?'},
                                                      StringSplitOptions
                                                      .RemoveEmptyEntries)
                                    .ToArray();

            var word = array.Where(x => x.Length < 5).OrderBy(x => x).Distinct();

            Console.WriteLine(string.Join(", ", word));
        }
    }
}
