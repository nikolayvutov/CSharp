using System;
namespace RawData
{
    public class Engine
    {
        private double speed;
        private double power;


        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Power
        {
            get { return power; }
            set { power = value; }
        }

        public Engine(double speed, double power)
        {
            this.Speed = speed;
            this.Power = power;
        }
    }
}
