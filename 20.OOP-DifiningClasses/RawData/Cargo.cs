using System;
namespace RawData
{
    public class Cargo
    {
        private double weight;
        private string type;


        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Cargo(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
    }
}
