using System;

namespace GarageParkingApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Garage Parking App");
            UI.CreateGarage(Util.AskForInt("Size of garage: "));   
        }
       
    }
}
