using System;
using System.Linq;

public class Phone : IBrowsable, ICallable
{
    private string[] numbers;
    private string[] websites;


    public Phone(string[] numbers, string[] websites)
    {
        this.Numbers = numbers;
        this.Websites = websites;
    }

    public string[] Numbers
    {
        get { return numbers; }
        private set { numbers = value; }
    }

    public string[] Websites
    {
        get { return websites; }
        private set { websites = value; }
    }

    public void Browsing()
    {
        foreach (var website in this.Websites)
        {
            if (website.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {website}!");
            }
        }
    }

    public void Calling()
    {
        foreach (var number in this.Numbers)
        {
            if (number.Any(char.IsDigit))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

