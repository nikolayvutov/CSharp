using System;

public class Private : ISoldier, IPrivate
{
    public int Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public double Salary { get; }

    public Private(int id, string firstName, string lastName, double salary)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Salary = salary;
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
    }
}

