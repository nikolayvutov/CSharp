using System;
using System.Globalization;


namespace CountWorkingDays
{
    class MainClass
    {
        public static void Main()
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(),
                                                     "dd-MM-yyyy",
                                                     CultureInfo.InvariantCulture);

            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(),
                                                     "dd-MM-yyyy",
                                                     CultureInfo.InvariantCulture);

            int counter = 0;

            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                if (!(i.Day == 1 && i.Month == 1) && !(i.Day == 3 && i.Month == 3) &&
                    !(i.Day == 1 && i.Month == 5) && !(i.Day == 6 && i.Month == 5)
                    && !(i.Day == 24 && i.Month == 5) && !(i.Day == 6 && i.Month == 9)
                    && !(i.Day == 22 && i.Month == 9) && !(i.Day == 1 && i.Month == 11)
                    && !(i.Day == 24 && i.Month == 12) && !(i.Day == 25 && i.Month == 12)
                    && !(i.Day == 26 && i.Month == 12) && !(i.DayOfWeek == DayOfWeek.Saturday || 
                                                             i.DayOfWeek == DayOfWeek.Sunday))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
