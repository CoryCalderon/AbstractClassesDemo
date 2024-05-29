using System;
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
             * Create an abstract class called Vehicle - DONE
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
            
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var carOne = new Car() 
            { 
                Make = "Ford",
                Model = "Fusion",
                Year = "2000",
                HasTrunk = true,
            };
            var motoOne = new Motorcycle()
            {
                Make = "Harley",
                Model = "Whatever",
                Year = "2020",
                HasSidecar = false,
            };
            var carTwo = new Car()
            {
                Make = "Chevy",
                Model = "Malibu",
                Year = "2020",
                HasTrunk = true,
            };
            var carThree = new Car()
            {
                Make = "Toyota",
                Model = "Tundra",
                Year = "2020",
                HasTrunk = true,
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            var vehicles = new List<Vehicle>() { carOne, carTwo, carThree, motoOne};

            foreach (var thing in vehicles)
            {
                Console.WriteLine(thing.Make, thing.Model, thing.Year);
            }
            // Call each of the drive methods for one car and one motorcycle
            carOne.DriveVirtual();
            carOne.DriveAbstract();

            motoOne.DriveVirtual();
            motoOne.DriveAbstract();
            #endregion            
            Console.ReadLine();
        }
    }
}
