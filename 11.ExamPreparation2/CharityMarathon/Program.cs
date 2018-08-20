using System;

namespace CharityMarathon
{
    class MainClass
    {
        public static void Main()
        {
            long daysMarathon = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long averageLapPerRunner = long.Parse(Console.ReadLine());
            long lengthOfTrack = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());


            long maxRunners = trackCapacity * daysMarathon;

            if (maxRunners < runners)
            {
                runners = maxRunners;
            
            }

            long totalMeters = runners * averageLapPerRunner * lengthOfTrack;
            long totalKm = totalMeters / 1000;
            decimal totalMoney = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
