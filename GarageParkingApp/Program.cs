using System;

namespace GarageParkingApp
{
    class Program
    {
        static GarageHandler garagehandler;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Garage Parking App");
            int capacity = Util.AskForInt("Size of garage: ");
            garagehandler = new GarageHandler(capacity);
            AddSeedData(garagehandler);
            UI.MainMenu();

            //Console.WriteLine("Welcome to Garage Parking App");
            //Console.WriteLine("Size of garage: ");
            //var size = Console.ReadLine(); //Util tryparse etc
            //var capacity = Int32.Parse(size);
            //garagehandler = new GarageHandler(capacity);

            // Lägga till bil: kolla först om garaget är fullt, är det fullt fråga ej envändaren efter RegNo etc. 
            // Leta efter bil: ange RegNo

            //garagehandler.GetSize();
        }

        private static void AddSeedData(GarageHandler garagehandler)
        {
            garagehandler.AddVehicle(new Car("ABC123", "Black", 4, "Sedan"));
            garagehandler.AddVehicle(new Motorcycle("DEF456", "Red", 4, 750));
        }
    }
}
