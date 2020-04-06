using System;
using System.Collections.Generic;
using System.Text;

namespace GarageParkingApp
{
    public class UI
    {
        static GarageHandler garagehandler;
        public static void MainMenu()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                                    + "\n1. Leave the garage"
                                    + "\n2. Park a car"
                                    + "\n3. "
                                    + "\n4. "
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
                        string regno = Util.AskForString("Enter the leaving vehicle regnumber: ");
                        garagehandler.Leave(regno);
                        
                        //UIMethods.LeaveGarage();
                        
                        //Console.WriteLine("Please enter the size of the garage");
                        //string garageSize = Console.ReadLine();
                        //var capacity = Int32.Parse(garageSize);
                        //GarageHandler garagehandler = new GarageHandler(capacity);
                        //garagehandler.GetGarageSize();
                        break;
                    case '2':                       
                        break;
                    case '3':
                        break;
                    case '4':
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
    }
}
