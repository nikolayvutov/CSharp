using System;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        :base(firstName, lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.FacultyNumber = facultyNumber;
    }

    public override string FirstName
    {
        get
        {
            return base.FirstName;
        }

        protected set
        {
            if (value.Length < 4)
            {
                throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");
            }
            base.FirstName = value;
        }
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

    public string FacultyNumber
    {
        get { return facultyNumber; }
        private set 
        {
            
            if (value.Length < 5 || value.Length > 10 || !IsValid(value))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return $"First Name: {FirstName}\nLast Name: {LastName}\nFaculty number: {FacultyNumber}";
    }

    public bool IsValid(string value)
    {
        bool isValid = true;
        foreach (var item in value)
        {
            if (!char.IsLetterOrDigit(item))
            {
                isValid = false;
            }
        }
        return isValid;
    }
}

