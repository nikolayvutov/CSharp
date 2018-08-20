using System;
using System.Text;

public class Spy : ISoldier, ISpy
{
    public int Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public int CodeNumber { get; }

    public Spy(int id, string firstName, string lastName, int codeNumber)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.CodeNumber = codeNumber;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}")
            .AppendLine($"Code Number: {this.CodeNumber}");

        return sb.ToString().Trim();
    }
}

