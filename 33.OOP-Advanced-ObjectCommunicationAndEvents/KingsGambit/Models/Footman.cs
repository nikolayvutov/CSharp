using System;
namespace KingsGambit.Models
{
    public class Footman : Subordinate
    {
        public Footman(string name) 
            : base(name, "panicking", 2)
        {
        }
    }
}
