using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Box box = new Box(l, w, h);

            Console.WriteLine("Surface Area - {0:f2}", box.SurfaceArea());
            Console.WriteLine("Lateral Surface Area - {0:f2}", box.LateralSurfaceArea());
            Console.WriteLine("Volume - {0:f2}", box.Volume());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
