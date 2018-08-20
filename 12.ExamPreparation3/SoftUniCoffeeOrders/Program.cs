using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCoffeeOrders
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                var price = ReadOrderAndCalculatePrice();
                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        static decimal ReadOrderAndCalculatePrice()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string dateStr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateStr, "d/M/yyyy", null);
            decimal capsulesCount = decimal.Parse(Console.ReadLine());

            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            decimal price = (daysInMonth * capsulesCount) * pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${price:F2}");

            return price;
        }
    }
}
