using System;
using _03BarracksFactory.Models.Units;

namespace P03_BarraksWars.Models.Units
{
    public class Gunner : Unit
    {

        private const int DefaultHealth = 50;
        private const int DefaultDamage = 10;

        public Gunner() 
            : base(DefaultHealth, DefaultDamage)
        {
        }
    }
}
