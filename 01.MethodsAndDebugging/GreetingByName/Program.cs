using System;

namespace methodsAndDebuggingexercises
{
    class MainClass
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            GreetingByName(name);
        }

        static void GreetingByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
