using System;

public class BankAccount
{
    private int id;
    private decimal balance;

    public int ID
    {
        get { return id; }
        set { id = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }


    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        this.Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID{ID}, balance {Balance:f2}";
    }
}

