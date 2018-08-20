using System;
namespace RawData
{
    public class Tire
    {
        public double tirePressure;
        public int age;

        public Tire(double pressure, int age)
        {
            this.tirePressure = pressure;
            this.age = age;
        }
    }
}
