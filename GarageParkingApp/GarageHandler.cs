using System;

namespace GarageParkingApp
{
    internal class GarageHandler
    {
        private Garage<Vehicle> garage;


        // UI frågar handler efter olika saker, ge mig fordonet med detta regno. Ge mig lista på alla fordon.
        // Handlern hanterar garaget
        public GarageHandler(int capacity)
        {
            // När vi instansierar ett garage så bestämmer vi vad den ska vara för typ och arrayens storlek.

            garage = new Garage<Vehicle>(capacity); 
        }

        //internal void Demo()
        //{

        //}

        // Här kan man ha en create garage metod som skickar in hur stort garaget ska vara exempelvis

        // GarageHandler skickar vidare till Garage. Garage Lägger till och tar bort.
        internal void GetSize()
        {
            garage.WriteSizeToConsole();
        }

    }
}