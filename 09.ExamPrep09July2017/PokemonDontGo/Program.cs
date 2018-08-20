using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();
            int reminder = 0;

            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                for (int i = 0; i < input.Count; i++)
                {
                    if (index > input.Count-1)
                    {
                        reminder = input[input.Count-1];
                        result.Add(reminder);
                        input.RemoveAt(input.Count-1);
                        input.Insert(input.Count, input[0]);

                        for (int l = 0; l < input.Count; l++)
                        {
                            if (input[l] > reminder)
                            {
                                input[l] -= reminder;
                            }
                            else if (input[l] <= reminder)
                            {
                                input[l] += reminder;
                            }
                        }
                        break;
                    }
                    if (index < 0)
                    {
                        reminder = input[0];
                        result.Add(reminder);
                        input.RemoveAt(0);
                        input.Insert(0, input[input.Count-1]);

                        for (int l = 0; l < input.Count; l++)
                        {
                            if (input[l] > reminder)
                            {
                                input[l] -= reminder;
                            }
                            else if (input[l] <= reminder)
                            {
                                input[l] += reminder;
                            }
                        }
                        break;
                    }

                    if (i == index)
                    {
                        reminder = input[i];
                        result.Add(reminder);
                        input.RemoveAt(index);

                        for (int l = 0; l < input.Count; l++)
                        {
                            if (input[l] > reminder)
                            {
                                input[l] -= reminder;
                            }
                            else if (input[l] <= reminder)
                            {
                                input[l] += reminder;
                            }
                        }
                    }

                }
            }
            int sum = 0;

            for (int i = 0; i < result.Count; i++)
            {
                sum += result[i];
            }
            Console.WriteLine(sum);
        }
    }
}
