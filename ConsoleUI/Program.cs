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
            * Todo follow all comments!! 
            */

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            List<Vehicle> myVehcilelist = new List<Vehicle>();

            Car myCar = new Car() { Year = 1999, Make = "Ford", Model = "Escape", HasTrunk = true };

            Motorcycle myMotorcycle = new Motorcycle() { Year = 2010, Make = "Harley", Model = "1", HasSideCart = false };

            Vehicle myVehicle1 = new Car() { Year = 2018, Make = "Toyota", Model = "Camry", HasTrunk = true };

            Vehicle myVehicle2 = new Car() {Year = 2022, Make = "Tesla", Model = "3", HasTrunk= true };

            myVehcilelist.Add(myCar);
            myVehcilelist.Add(myMotorcycle);
            myVehcilelist.Add(myVehicle1);
            myVehcilelist.Add(myVehicle2);

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            int counter = 1;
            foreach (Vehicle vehicle in myVehcilelist) 
            {
                Console.WriteLine($"Vehicle {counter}");
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
                counter++;
            }

            // Call each of the drive methods for one car and one motorcycle

        }
    }
}
