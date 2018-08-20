using System;

namespace temperatureConversion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double celsius = FahrenheitToCelsius(n);
            Console.WriteLine($"{celsius:f2}");

        }
        static double FahrenheitToCelsius(double n)
        {
            double celsius = (n - 32) * 5 / 9;
            return celsius;
        }
    }
}
