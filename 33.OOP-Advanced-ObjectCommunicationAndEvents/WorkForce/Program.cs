namespace WorkForce
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using WorkForce.Interfaces;

    class Program
    {
        static void Main(string[] args)
        {
            List<IJob> jobs = new List<IJob>();
            List<IEmployee> employees = new List<IEmployee>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                switch (tokens[0])
                {
                    case "StandardEmployee":
                        IEmployee employee = new StandardEmployee(tokens[1]);
                        employees.Add(employee);
                        break;
                    case "PartTimeEmployee":
                        employee = new PartTimeEmployee(tokens[1]);
                        employees.Add(employee);
                        break;
                    case "Job":
                        var empl = employees.First(e => e.Name == tokens[3]);
                        Job job = new Job(tokens[1], int.Parse(tokens[2]), empl);
                        jobs.Add(job);
                        break;
                    case "Pass":
                        jobs.Where(j => !j.IsDone).ToList().ForEach(j => j.Update());
                        break;
                    case "Status":
                        jobs.ForEach(j => Console.WriteLine(j.ToString()));
                        break;
                }
            }
        }
    }
}
