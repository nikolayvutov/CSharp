using System;
using System.Collections.Generic;
using System.Linq;

class RectangleIntersection
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int numberOfRectangles = input[0];
        int intersectionChecks = input[1];
        List<Rectangle> rectangles = new List<Rectangle>();

        for (int i = 0; i < numberOfRectangles; i++)
        {
            var tokens = Console.ReadLine().Split();
            string id = tokens[0];
            double width = double.Parse(tokens[1]);
            double height = double.Parse(tokens[2]);
            int horizontal = int.Parse(tokens[3]);
            int vertical = int.Parse(tokens[4]);

            Rectangle rectangle = new Rectangle(id, width, height, horizontal, vertical);
            rectangles.Add(rectangle);
        }

        for (int i = 0; i < intersectionChecks; i++)
        {
            var compareCouple = Console.ReadLine().Split();
            string first = compareCouple[0];
            string second = compareCouple[1];


        }
    }

    private static bool AreRectanglesIntersect(string first, string second, List<Rectangle> rects)
    {
        var firstRec = rects.Where(c => c.id == first);
        var secondRec = rects.Where(r => r.id == second);

        Rectangle rec 
    }
}

