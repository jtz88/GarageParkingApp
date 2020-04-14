using System;
using System.Linq;

namespace GarageParkingApp
{
    internal class GarageHandler
    {
        private Garage<Vehicle> garage;

        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity); 
        }

        internal bool AddVehicle(Vehicle vehicle)
        {
            return garage.Add(vehicle);
        } 
        
        internal bool Leave(string regno)
        {
            var vehicle = garage.FirstOrDefault(v => v.RegNo == regno);
            return vehicle is null ? false : garage.Leave(vehicle);          
        }

        internal void GetAllParkedVehicles()
        {
            garage.GetEnumerator();
        }

        internal bool HasCapacityFor(int seedNrOfVehicles)
        {
            return garage.GetNrOfFreeSpaces >= seedNrOfVehicles;
        }

        internal int AvailableParkingSlots()
        {
            int result = garage.AvailableParkingSlots();
            return result;
        }

        internal void OutputAllVehicles()
        {
            garage.OutputAllVehicles();
        }
    }
}