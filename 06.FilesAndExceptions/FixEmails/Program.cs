using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

namespace FixEmails
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var lines = File.ReadAllLines(@"../../../resources/6. Fix Emails/text.txt");

            File.Delete(@"../../../resources/6. Fix Emails/output.txt");
            for (int i = 0; i < lines.Length; i += 2)
            {
                if (lines[i] == "stop" || lines[i + 1] == "stop")
                {
                    break;
                }

                var name = lines[i];
                var email = lines[i + 1];

                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }
                var output = $"{name} -> {email}" + Environment.NewLine;

                File.AppendAllText(@"../../../resources/6. Fix Emails/output.txt", output);
            }
        }
    }
}