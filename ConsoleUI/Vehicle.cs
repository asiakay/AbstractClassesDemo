using System;
using System.Collections.Generic;
using System.Linq;
//* Create an abstract class called Vehicle
//         * The vehicle class shall have three string properties Year, Make, and Model
//         * Set the defaults to something generic in the Vehicle class
//         * Vehicle shall have an abstract method called DriveAbstract with no implementation
//         * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
//         */
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 1981;
        public string Make { get; set; } = "Nissan";
        public string Model { get; set; } = "Altima";
        public string Color { get; set; } = "Gray";
        public bool Condition { get; set; } = false;

        public abstract void DriveAbstract();
        //stubbed out method return void

        public virtual void DriveVirtual()
        // virtual method
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive!"); ;
        }

    }
}






 