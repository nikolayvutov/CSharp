using System;

namespace geometryCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string figure = Console.ReadLine();


        }
        static double Figures(string figure)
        {
            double result;
            if (figure == "triangle")
            {
                int a = int.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                result = a * h / 2;
            }
            else if (figure == "rectangle")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                result = a * b;
            }
            else if (figure == "square")
            {
                int a = int.Parse(Console.ReadLine());
                result = a * a;

            }
            else if (figure == "circle")
            {
                int side = int.Parse(Console.ReadLine());

                result = side * r;

            }


        }
    }
}
