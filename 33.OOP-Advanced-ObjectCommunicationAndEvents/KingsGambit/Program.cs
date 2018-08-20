namespace KingsGambit
{
    using System;
    using System.Collections.Generic;
    using KingsGambit.Contracts;
    using KingsGambit.Models;

    class Program
    {
        static void Main(string[] args)
        {
            IKing king = SetupKing();

            Engine engine = new Engine(king);
            engine.Run();
        }

        private static IKing SetupKing()
        {
            string kingName = Console.ReadLine();
            IKing king = new King(kingName, new List<ISubordinate>());

            string[] royalGuardNames = Console.ReadLine().Split();
            foreach (var name in royalGuardNames)
            {
                king.AddSubordinate(new RoyalGuard(name));
            }

            string[] footmanName = Console.ReadLine().Split();
            foreach (var name in footmanName)
            {
                king.AddSubordinate(new Footman(name));
            }

            return king;
        }
    }
}
