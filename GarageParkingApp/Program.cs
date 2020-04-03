using System;

namespace GarageParkingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageHandler garagehandler = new GarageHandler(8);
            garagehandler.GetSize();
            UI.InitializeUI();
        }
    }
}
