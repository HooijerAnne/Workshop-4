using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_4.Interfaces;

namespace Workshop_4.Models
{
    public class Truck : Vehicle, iStartEngine, iStopEngine, iLoadCargo
    {
        // Constructor
        public Truck(string color)
        {
            Color = color;
        }

        // Interface method implementations
        public void turnOn()
        {
            Console.WriteLine($"{Color} Truck engine started");
        }

        public void turnOff()
        {
            Console.WriteLine($"{Color} Truck engine stopped");
        }

        public void load()
        {
            Console.WriteLine($"{Color} Truck loading cargo");
        }

        // Vehicle method overrides
        public override void forward()
        {
            Console.WriteLine($"{Color} Truck moving forward");
        }

        public override void backward()
        {
            Console.WriteLine($"{Color} Truck moving backward");
        }

        public override void stop()
        {
            Console.WriteLine($"{Color} Truck stopped");
        }
    }
}
