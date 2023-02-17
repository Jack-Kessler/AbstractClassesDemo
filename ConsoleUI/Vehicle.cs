using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; } = 1990;
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving Virtually - Default");
        }

    }
}
