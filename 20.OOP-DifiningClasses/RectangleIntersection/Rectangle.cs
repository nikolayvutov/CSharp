using System;
using System.Collections.Generic;
using System.Linq;

public class Rectangle
{
    public string id;
    public double width;
    public double height;
    public int horizontal;
    public int vertical;

    public Rectangle(string id, double width, double height, int horizontal, int vertical)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.horizontal = horizontal;
        this.vertical = vertical;
    }

    public bool Intersect(string rect1, string rect2, List<Rectangle> rects)
    {


        var firstRec = rects.Where(c => c.id == rect1);
        var secondRec = rects.Where(r => r.id == rect2);

        var XFirst = firstRec.Where(x => x.);
    }
}
