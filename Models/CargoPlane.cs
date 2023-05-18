using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_4.Interfaces;

namespace Workshop_4.Models
{
    public class CargoPlane : Plane, iLoadCargo
    {
        // Constructor
        public CargoPlane(string color) : base(color)
        {
            Color = color;
        }

        // Interface method implementation
        public void load()
        {
            Console.WriteLine($"{Model} is loading cargo");
        }
    }
}
