using System;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5);
        Shape rectancle = new Rectangle(5, 10);

        Console.WriteLine(circle.Draw());
        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());

        Console.WriteLine(rectancle.Draw());
        Console.WriteLine(rectancle.CalculateArea());
        Console.WriteLine(rectancle.CalculatePerimeter());
    }
}
