using System;
using System.Collections;
using System.Collections.Generic;

namespace GarageParkingApp
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }

        // Lägger till bilar i sin privata array
        //public bool Park(T vehicle)
        //{

        //}

        public void WriteSizeToConsole()
        {
            var arrayLength = vehicles.Length;
            Console.WriteLine(arrayLength);
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //private int garagesize;
        //private T[] vehicles;
        //public Garage(int garagesize)
        //{
        //    this.garagesize = garagesize;
        //    vehicles = new T[garagesize]();
        //}
    }
}