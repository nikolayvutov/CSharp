using System;
using System.Linq;
using System.IO;

namespace LineNumbers
{
    class MainClass
    {
        public static void Main()
        {
            string[] lines = File.ReadAllLines(@"../../../Resources/02. Line Numbers/Input.txt");

            var numberedLines = lines.Select((line, i) => $"{i + 1}. {line}");

            File.WriteAllLines(@"../../../Resources/02. Line Numbers/output.txt", numberedLines);
        }
    }
}
