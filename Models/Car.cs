using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_4.Interfaces;

namespace Workshop_4.Models
{
    public class Car : Vehicle, iStartEngine, iStopEngine
    {
        // Constructor
        public Car(string color)
        {
            Color = color;
        }

        // Interface method implementations
        public void turnOn()
        {
            Console.WriteLine($"{Color} Car engine started");
        }

        public void turnOff()
        {
            Console.WriteLine($"{Color} Car engine stopped");
        }

        // Vehicle method overrides
        public override void forward()
        {
            Console.WriteLine($"{Color} Car moving forward");
        }

        public override void backward()
        {
            Console.WriteLine($"{Color} Car moving backward");
        }

        public override void stop()
        {
            Console.WriteLine($"{Color} Car stopped");
        }

    }
}
