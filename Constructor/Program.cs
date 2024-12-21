using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
        }
    }



    public class Car
    {
        // constructor
        public Car()
        {

        }

        // constructor overloading
        public Car(string model, string marka, string color)
        {
            Marka = marka;
            Model = model;
            Color = color;
        }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string Color { get; set; }
    }
}

