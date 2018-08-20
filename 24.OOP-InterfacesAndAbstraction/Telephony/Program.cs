using System;

class Program
{
    static void Main(string[] args)
    {
        var phones = Console.ReadLine().Split();
        var websites = Console.ReadLine().Split();

        Phone phone = new Phone(phones, websites);
        phone.Calling();
        phone.Browsing();
    }
}

