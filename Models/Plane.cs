using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_4.Interfaces;

namespace Workshop_4.Models
{
    public class Plane : iStartEngine, iStopEngine, iFly
    {
        // properties plane
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Constructor
        public Plane(string model)
        {
            Model = model;

        }

        // Interface method implementations
        public void turnOn()
        {
            Console.WriteLine($"{Color} Plane engine started");
        }

        public void turnOff()
        {
            Console.WriteLine($"{Color} Plane engine stopped");
        }

        public void takingOff()
        {
            Console.WriteLine($"{Model} is taking off to New York City");
        }

        public void landing()
        {
            Console.WriteLine($"{Model} is landing at 2 pm in Dubai.");
        }

    }
}
