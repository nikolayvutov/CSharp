using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static Dictionary<string, List<string>> doctors;

    private static Dictionary<string, List<List<string>>> departments;

    public static void Main()
    {
        doctors = new Dictionary<string, List<string>>();
        departments = new Dictionary<string, List<List<string>>>();

        string command;
        while ((command = Console.ReadLine())!= "Output")
        {
            string[] tokens = command.Split();
            var department = tokens[0];
            var firstName = tokens[1];
            var secondName = tokens[2];
            var patient = tokens[3];
            var fullName = firstName + secondName;

            AddInDoctors(fullName);

            AddInDepartments(department);

            bool hasPlace = departments[department]
                .SelectMany(x => x).Count() < 60;

            if (hasPlace)
            {
                AddPatient(department, patient, fullName);
            }
        }

        while ((command = Console.ReadLine())!= "End")
        {
            PrintReadedCommand(command);
        }
    }

    private static void AddPatient(string department, string patient, string fullName)
    {
        int room = 0;
        doctors[fullName].Add(patient);
        for (int rooms = 0; rooms < departments[department].Count; rooms++)
        {
            if (departments[department][rooms].Count < 3)
            {
                room = rooms;
                break;
            }
        }
        departments[department][room].Add(patient);
    }

    private static void AddInDepartments(string department)
    {
        if (!departments.ContainsKey(department))
        {
            departments[department] = new List<List<string>>();
            for (int rooms = 0; rooms < 20; rooms++)
            {
                departments[department].Add(new List<string>());
            }
        }
    }

    private static void AddInDoctors(string fullName)
    {
        if (!doctors.ContainsKey(fullName))
        {
            doctors[fullName] = new List<string>();
        }
    }

    private static void PrintReadedCommand(string command)
    {
        string[] args = command.Split();

        if (args.Length == 1)
        {
            Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
        }
        else if (args.Length == 2 && int.TryParse(args[1], out int staq))
        {
            Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
        }
        else
        {
            Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
        }
    }
}