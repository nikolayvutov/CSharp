using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandInterpreter
{
    class MainClass
    {
        public static void Main()
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ' },
                                                       StringSplitOptions
                                                       .RemoveEmptyEntries)
                                     .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var command = input.Split(' ');

                if (command[0] == "reverse")
                {
                    list.Reverse(int.Parse(command[2]), int.Parse(command[4]));
                }
                else if (command[0] == "sort")
                {
                    try
                    {
                        int fromIndex = int.Parse(command[2]);
                        int toIndex = int.Parse(command[4]);
                        List<string> array = list.Skip(fromIndex).Take(toIndex).ToList();
                        array.Sort();
                        list.RemoveRange(fromIndex, toIndex);
                        list.InsertRange(fromIndex, array);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                }
                else if (command[0] == "rollLeft")
                {
                    try
                    {
                        int n = int.Parse(command[1]);
                        for (int i = 0; i < n; i++)
                        {
                            string temp = list.First();
                            list.RemoveAt(0);
                            list.Add(temp);
                        }
                    }
                    catch 
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                }
                else if (command[0] == "rollRight")
                {
                    try
                    {
                        int n = int.Parse(command[1]);
                        for (int i = 0; i < n; i++)
                        {
                            string temp = list.Last();
                            list.RemoveAt(list.Count - 1);
                            list.Insert(0, temp);
                        }
                    }
                    catch 
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }

                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }
    }
}
