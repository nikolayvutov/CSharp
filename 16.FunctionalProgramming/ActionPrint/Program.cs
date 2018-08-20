using System;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", Console.ReadLine()
                                          .Split(new[]{' '},StringSplitOptions
                                                 .RemoveEmptyEntries)));
        }
    }
}
