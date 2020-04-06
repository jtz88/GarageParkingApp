using System;
using System.Collections.Generic;
using System.Text;

namespace GarageParkingApp
{
    internal class Motorcycle : Vehicle
    {
        public int Cylinder { get; set; }

        public Motorcycle(string regno, string color, int wheels, int cylinder) : base(regno, color, wheels)
        {
            Cylinder = cylinder;
        }
    }
}
