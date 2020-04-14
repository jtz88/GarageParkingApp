using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GarageParkingApp
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }

        public int GetNrOfFreeSpaces => vehicles.Where(v => v is null).Count();    


        internal void OutputAllVehicles()
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    Console.WriteLine($"Parking slot {i+1} is occupied by vehicle with regnumber: {vehicles[i].RegNo}");
                }
            }
        }

        internal bool Add(T vehicle)
        {
            bool result= false;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if(vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    result = true;
                    break;
                }
            }
            return result;
        } 
        
        internal bool Leave(T vehicle)
        {
            bool result= false;

            for (int i = 0; i < vehicles.Length; i++)      
            {
                if(vehicles[i] == vehicle)
                {
                    vehicles[i] = null;
                    result = true;
                    break;
                }
            }
            return result;
        }

        public int AvailableParkingSlots()
        {
            var result = vehicles.Where(v => v is null).Count();
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var v in vehicles)
            {
                if (v != null) yield return v;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}