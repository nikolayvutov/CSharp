using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new Dictionary<string, List<string>>();
            var doctors = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Output")
            {
                var tokens = input.Split().ToArray();

                string department = tokens[0];
                string doctor = tokens[1] + " " + tokens[2];
                string patient = tokens[3];

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new List<string>();
                }
                if (!doctors.ContainsKey(doctor))
                {
                    doctors[doctor] = new List<string>();
                }

                departments[department].Add(patient);
                doctors[doctor].Add(patient);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split().ToArray();

                if (tokens.Length == 1)
                {
                    foreach (var p in departments[tokens[0]])
                    {
                        Console.WriteLine(p);
                    }
                }
                else
                {
                    string doctor = tokens[0] + " " + tokens[1];

                    if (doctors.ContainsKey(doctor))
                    {
                        foreach (var p in doctors[doctor].OrderBy(x => x))
                        {
                            Console.WriteLine(p);
                        }
                    }
                    else
                    {
                        int n = int.Parse(tokens[1]);
                        foreach (var p in departments[tokens[0]]
                                 .Skip((n*3)-3).Take(3).OrderBy(x => x))
                        {
                            Console.WriteLine(p);
                        }
                    }
                }
            }
        }
    }
}
