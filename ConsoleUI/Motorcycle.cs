using System;
using System.Collections.Generic;
using System.Linq;
//Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
//             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
//             * Provide the implementations for the abstract methods
//             * Only in the Motorcycle class will you override the virtual drive method
//            */

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool hasSidecar { get; set; } = true;

        //hovered over the compile error and generated exc
        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is moving fast!!!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is {GetType().BaseType.Name} is virtually in drive");
        }
    }
}
