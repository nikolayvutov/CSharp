using System;
using System.Collections.Generic;
using System.Text;

namespace simpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            var oldVersions = new Stack<string>();
            oldVersions.Push("");

            var text = new StringBuilder();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split();
                int n = int.Parse(command[0]);

                switch (n)
                {
                    case 1:
                        oldVersions.Push(text.ToString());
                        text.Append(command[1]);
                        break;
                    case 2:
                        oldVersions.Push(text.ToString());
                        int length = int.Parse(command[1]);
                        text.Remove(text.Length - length, length);
                        break;
                    case 3:
                        int index = int.Parse(command[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        text.Clear();
                        text.Append(oldVersions.Pop());
                        break;
                }
            }
        }
    }
}
