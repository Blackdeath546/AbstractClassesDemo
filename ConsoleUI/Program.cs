﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             */
            Car funCar = new Car() {Year = "2024", Make = "ClownCar", Model = "HonkHonk", HasFwd = true};
            Motorcycle burnerCycle = new Motorcycle() {Year = "1960", Make = "Harley", Model = "Ford", HasTwoSideCarts = true};
            Vehicle theGoatCar = new Car(){Year = "2024", Make = "ClownCar", Model = "HonkHonk", HasTwd = true};
            Vehicle  theSmexyMotorcycle = new Motorcycle(){Year = "2024", Make = "ClownCar", Model = "HonkHonk", HasSideCart = true};
            
            
             /* Set the properties values with object initializer syntax
             */
            

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            vehicles.Add(funCar);
            vehicles.Add(burnerCycle);
            vehicles.Add(theGoatCar);
            vehicles.Add(theSmexyMotorcycle);
            foreach (Vehicle vehicle in vehicles)
            {
             //Console.WriteLine($"{vehicle.Year} - {vehicle.Make} - {vehicle.Model}");
             //}

             // Call each of the drive methods for one car and one motorcycle
             vehicle.DriveVirtual();
             vehicle.DriveAbstract();
             Console.WriteLine("\n");
             
            }

            #endregion            
        }
    }
}
