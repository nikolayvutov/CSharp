using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrases = File.ReadLines(@"../../../resources/7. Advertisement Message/phrases.txt").ToArray();
            var events = File.ReadLines(@"../../../resources/7. Advertisement Message/events.txt").ToArray();
            var authors = File.ReadLines(@"../../../resources/7. Advertisement Message/authors.txt").ToArray();
            var cities = File.ReadLines(@"../../../resources/7. Advertisement Message/cities.txt").ToArray();

            int n = int.Parse(Console.ReadLine());

            Random rdm = new Random();

            for (int i = 0; i < n; i++)
            {
                var output = $"{phrases[i]} {events[i]} {authors[i]} {cities[i]}." + Environment.NewLine;

                File.AppendAllText(@"../../../resources/7. Advertisement Message/output.txt", output);
            }
        }
    }
}