using System;

namespace mathPower
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            RaiseToPower(number, power);

        }
        static void RaiseToPower(double number, double power)
        {
            
            double result = Math.Pow(number, power);
            Console.WriteLine(result);
        }
    }
}
