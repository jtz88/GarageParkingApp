using System;
using System.Collections.Generic;
using System.Text;

namespace GarageParkingApp
{
    public class UI
    {
        static GarageHandler garagehandler;

        internal static void CreateGarage(int capacity)
        {
            garagehandler = new GarageHandler(capacity);
            MainMenu();
        }

        public static void MainMenu()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                                    + "\n1. Leave the garage"
                                    + "\n2. Park a vehicle"
                                    + "\n3. How many parking slots are available?"
                                    + "\n4. Add seed"
                                    + "\n0. Exit the application");

                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        Console.Clear();
                        garagehandler.OutputAllVehicles();
                        var leaveRegno = Util.AskForString("Enter the leaving vehicle regnumber: ").ToUpper();
                        var leaveMessage = garagehandler.Leave(leaveRegno) ? "Vehicle with the following regnumber has left the garage: " : "Vehicle with the following regnumber is not parked in the garage: ";
                        Console.Clear();
                        Console.WriteLine($"{leaveMessage}{leaveRegno}\n");
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine("1. Park Car");
                        Console.WriteLine("2. Park Motorcycle");
                        var selection = Console.ReadLine();
                        if (selection == "1")
                        {
                            var parkRegno = Util.AskForString("Enter regno: ").ToUpper();
                            var parkColor = Util.AskForString("Enter color: ").ToUpper();
                            var parkWheels = Util.AskForInt("Enter wheels: ");
                            var parkModel = Util.AskForString("Enter model (Coupe or Sedan): ").ToUpper(); // Enum 1 för Coupe, 2 för Sedan?
                            Car parkCar = new Car(parkRegno, parkColor, parkWheels, parkModel);
                            var parkMessage = garagehandler.AddVehicle(parkCar) ? "Vehicle with the following regnumber has been parked: " : "Garage is full! Vehicle has not been parked: ";
                            Console.Clear();
                            Console.WriteLine($"{parkMessage}{parkRegno}\n");
                        }
                        else if (selection == "2")
                        {
                            var parkRegno = Util.AskForString("Enter regno: ").ToUpper();
                            var parkColor = Util.AskForString("Enter color: ").ToUpper();
                            var parkWheels = Util.AskForInt("Enter wheels: ");
                            var parkCyl = Util.AskForInt("Enter cylinders: ");
                            Motorcycle parkMc = new Motorcycle(parkRegno, parkColor, parkWheels, parkCyl);
                            var parkMessage = garagehandler.AddVehicle(parkMc) ? "Vehicle with the following regnumber has been parked: " : "Garage is full! Vehicle has not been parked: ";
                            Console.Clear();
                            Console.WriteLine($"{parkMessage}{parkRegno}\n");
                        }
                        break;
                    case '3': 
                        int result = garagehandler.AvailableParkingSlots();
                        Console.Clear();
                        Console.WriteLine($"Available parking slots: {result}\n"); 
                        break;
                    case '4':
                        Console.Clear();
                        var seedNrOfVehicles = Util.AskForInt("How many vehicles should be added to the garage? (Maximum amount is 5): ");
                        AddSeedData(seedNrOfVehicles);
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        private static void AddSeedData(int seedNrOfVehicles)
        {
            var result = garagehandler.AvailableParkingSlots();
            if (result < seedNrOfVehicles)
            {
                Console.Clear();
                Console.WriteLine("Error! Amount of seed vehicles exceed garage capacity\n");
            }

            else if (garagehandler.HasCapacityFor(seedNrOfVehicles))
            {
                var v = GetSeed();

                if (seedNrOfVehicles > v.Length)
                {
                    Console.Clear();
                    Console.WriteLine("Error! Maximum amount of seed exceeded\n");
                }
                else
                for (int i = 0; i < seedNrOfVehicles; i++)
                {
                    garagehandler.AddVehicle(v[i]);
                }
            }
        }

        private static Vehicle[] GetSeed()
        {

            return  new Vehicle[]
            {
                new Car("ABC123", "Black", 4, "Sedan"),
                new Motorcycle("DEF456", "Red", 2, 750),
                new Car("ZYX987", "White", 4, "Sedan"),
                new Motorcycle("JKL086", "Blue", 3, 950),
                new Car("POL532", "Orange", 4, "Sedan"),
            };
            
        }
    }
}
