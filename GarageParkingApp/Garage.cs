using System;
using System.Collections;
using System.Collections.Generic;

namespace GarageParkingApp
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }

        // Lägger till bilar i sin privata array
        //public bool Park(T vehicle)
        //{

        //}

        //public static void OutputGarageSize()
        //{
        //    var garageSize = vehicles.Length;
        //    Console.WriteLine($"The size of the garage is: {garageSize}");
        //}

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

        //public void Add(string regno)
        //{
        //    New instance of employee
        //    Add emplyee to list
        //    employees.Add(new Employee(name, salary));

        //}

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

        //private int garagesize;
        //private T[] vehicles;
        //public Garage(int garagesize)
        //{
        //    this.garagesize = garagesize;
        //    vehicles = new T[garagesize]();
        //}
    }
}