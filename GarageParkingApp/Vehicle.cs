namespace GarageParkingApp
{
    internal class Vehicle
    {
        public string RegNo { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }

        public Vehicle(string regno, string color, int wheels)
        {
            RegNo = regno;
            Color = color;
            Wheels = wheels;
        }

    }
}