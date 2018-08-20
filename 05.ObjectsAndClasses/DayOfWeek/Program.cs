using System;
using System.Globalization;

namespace DayOfWeek
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime myDate = DateTime.ParseExact(input,
                                                  "d-M-yyyy",
                                                  CultureInfo.InvariantCulture);

            Console.WriteLine(myDate.DayOfWeek);
        }
    }
}
