using System;
using System.Linq;

public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public virtual string FirstName
    {
        get { return firstName; }
        protected set 
        {
            if (!Char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            firstName = value; 
        }
    }

    public virtual string LastName
    {
        get { return lastName; }
        protected set 
        { 
            if (!Char.IsUpper(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
            lastName = value; 
        }
    }
}

