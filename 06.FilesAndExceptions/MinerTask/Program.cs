using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AMinerTask
{
    class MainClass
    {
        public static void Main()
        {
            var lines = File.ReadAllLines(@"../../../resources/5. A Miner Task/text.txt");

            File.Delete(@"../../../resources/5. A Miner Task/output.txt");

            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }

                var resource = lines[i];
                var quantity = lines[i + 1];

                var output = $"{resource} -> {quantity}" + Environment.NewLine;

                File.AppendAllText(@"../../../resources/5. A Miner Task/output.txt", output);
            }
        }
    }
}