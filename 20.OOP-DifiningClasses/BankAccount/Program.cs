using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();
            var cmdType = tokens[0];

            switch (cmdType)
            {
                case "Create":
                    Create(tokens, accounts);
                    break;
                case "Deposit":
                    Deposit(tokens, accounts);
                    break;
                case "Withdraw":
                    Withdraw(tokens, accounts);
                    break;
                case "Print":
                    Print(tokens, accounts);
                    break;
            }
        }
    }

    private static void Print(string[] tokens, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(tokens[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id].ToString());
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }

    }

    private static void Withdraw(string[] tokens, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(tokens[1]);
        var amount = decimal.Parse(tokens[2]);

        if (accounts.ContainsKey(id))
        {
            if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Withdraw(amount);
            }
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Deposit(string[] tokens, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(tokens[1]);
        var amount = decimal.Parse(tokens[2]);

        if (accounts.ContainsKey(id))
        {
            accounts[id].Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }
    }

    private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);

        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            var acc = new BankAccount();
            acc.ID = id;
            accounts.Add(id, acc);
        }
    }


}

