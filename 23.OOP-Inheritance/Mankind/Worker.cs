using System;

public class Worker : Human
{
    private decimal weekSalary;
    private double workingHours;

    public Worker(string firstName, string lastName, 
                  decimal weekSalary, double workingHours)
        :base(firstName, lastName)
    {
        this.LastName = lastName;
        this.WeekSalary = weekSalary;
        this.WorkingHours = workingHours;
    }

    public override string LastName
    {
        get
        {
            return base.LastName;
        }

        protected set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
            }
            base.LastName = value;
        }
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        private set
        {
            if (value <= 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    public double WorkingHours
    {
        get { return workingHours; }
        private set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
            }
            workingHours = value;
        }
    }

    public override string ToString()
    {
        return $"First Name: {FirstName}\nLast Name: {LastName}\nWeek Salary: {WeekSalary:F2}\nHours per day: {WorkingHours:F2}\nSalary per hour: {SalaryPerHour():F2}";
    }

    public decimal SalaryPerHour()
    {
        return this.WeekSalary / (decimal)(this.WorkingHours * 5);
    }
}

