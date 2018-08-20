using System;

public class DateModifier
{
    private DateTime firstDate;
    private DateTime secondDate;


    public DateTime FirstDate
    {
        get { return firstDate; }
        set { firstDate = value; }
    }

    public DateTime SecondDate
    {
        get { return secondDate; }
        set { secondDate = value; }
    }

    public int CalculateDifference(DateTime firstDate, DateTime secondDate)
    {
        return Math.Abs((secondDate - firstDate).Days);
    }
}

