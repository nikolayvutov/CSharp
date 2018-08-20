namespace WorkForce
{
    using System;
    using WorkForce.Interfaces;

    public class Job : IJob
    {
        public Job(string name, int hours, IEmployee employee)
        {
            this.Name = name;
            this.RequiredWorkHours = hours;
            this.Employee = employee;
            this.IsDone = false;
        }
        public bool IsDone { get; set; }

        public string Name { get; }

        public int RequiredWorkHours { get; set; }

        public IEmployee Employee { get; }

        public void Update()
        {
            this.RequiredWorkHours -= Employee.WorkHoursPerWeek;

            if (this.RequiredWorkHours <= 0)
            {
                Console.WriteLine($"Job {this.Name} done!");
                this.IsDone = true;
            }
        }

		public override string ToString()
		{
            if (!IsDone)
            {
                return $"Job: {this.Name} Hours Remaining: {this.RequiredWorkHours}";
            }

            return "".Trim();
		}
	}
}
