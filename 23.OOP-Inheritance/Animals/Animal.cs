using System;

public class Animal
{
    private string name;
    private int age;
    private string gender;
    private string type;

    public Animal(string name, int age, string gender, string type)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
        this.Type = type;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            name = value;
        }
    }

    public string Type
    {
        get { return type; }
        set
        {
            type = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || string.IsNullOrWhiteSpace(value.ToString()) ||
                string.IsNullOrEmpty(value.ToString())) // Possible Exception <= 0
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public virtual string Gender
    {
        get { return gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            gender = value;
        }
    }
    public virtual string ProduceSound()
    {
        return "";
    }
}

