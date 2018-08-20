namespace KingsGambit
{
    using System;
    using System.Linq;
    using KingsGambit.Contracts;


    public class Engine
    {
        private IKing king;

        public Engine(IKing king)
        {
            this.king = king;
        }

        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Attack")
                {
                    king.GetAttacked();
                }
                else if (command == "Kill")
                {
                    string name = tokens[1];
                    ISubordinate subordinate = king.Subordinates
                                       .First(s => s.Name == name);
                    subordinate.TakeDamage();
                }
            }
        }
    }
}
