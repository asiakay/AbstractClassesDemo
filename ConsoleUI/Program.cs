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

            #region Vehicles

            /*Done
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /*Done 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
            //Done
            // Create a list of Vehicle called vehicles
            // local variable vehicles points to a new list based off the vehicle class?
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of 
             * // type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            Car Honda = new Car() { HasTrunk = true, Make = "Honda",
                Model = "Civic", Color = "Blue", Year = 2011 };

            Motorcycle vespa = new Motorcycle() { hasSidecar = true,
                Make = "Vespa", Model = "Scootaround", Year = 2020};

            Vehicle Mercedez = new Car { HasTrunk = true,
                Make = "Mercedez Benz", Model = "E-Class", Color="White",
                Year=2020};

            Vehicle Kia = new Car() { HasTrunk = true, Make = "Kia",
                Model ="Optima", Year=2015, Color="Black" };



            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(Honda);
            vehicles.Add(vespa);
            vehicles.Add(Mercedez);
            vehicles.Add(Kia);

            foreach (var _vehicle in vehicles)
                //cycles through all variables in a collection
            {
                Console.WriteLine($"Make: {_vehicle.Make} " +
                    $"Model: {_vehicle.Model} Year: {_vehicle.Year}");

                // Call each of the drive methods for one car and one motorcycle

                _vehicle.DriveAbstract();
                _vehicle.DriveVirtual();


            }

            


            #endregion            
            Console.ReadLine();
        }
    }
}
