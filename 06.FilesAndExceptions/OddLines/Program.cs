using System;
using System.IO;
using System.Linq;

namespace OddLines
{
    class MainClass
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines(@"../../Resources/01. Odd Lines/Input.txt");

            var oddLines = lines.Where((line, i) => i % 2 == 1);

            File.WriteAllLines(@"../../Resources/01. Odd Lines/odd-lines.txt", oddLines);
        }
    }
}
