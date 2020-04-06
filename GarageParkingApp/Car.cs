using System;
using System.Collections.Generic;
using System.Text;

namespace GarageParkingApp
{
    internal class Car : Vehicle
    {
        public string Model { get; set; }

        public Car(string regno, string color, int wheels, string model) : base(regno,  color, wheels)
        {
            Model = model;
        }
    }
}
