namespace WorkForce
{
    public abstract class Employee : IEmployee
    {
        protected Employee(string name, int workHours)
        {
            this.Name = name;
            this.WorkHoursPerWeek = workHours;
        }

        public string Name { get; }

        public int WorkHoursPerWeek { get; }
    }
}
