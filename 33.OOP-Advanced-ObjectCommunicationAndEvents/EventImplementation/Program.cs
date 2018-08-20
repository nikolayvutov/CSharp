namespace EventImplementation
{
    using System;
    using EventImplementation.Contracts;

    class Program
    {
        static void Main(string[] args)
        {
            INameChangable dispatcher = new Dispatcher("Pesho");
            INameChangeHandler handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameCHange;

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                dispatcher.Name = input;


            }
        }
    }
}
