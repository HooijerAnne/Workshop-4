using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_4.Models
{
    public class Bike : Vehicle
    {
        // Constructor
        public Bike(string color)
        {
            Color = color;
        }


        // interface method inhertance from Vehicle class
        public override void forward()
        {
            Console.WriteLine($"{Color} Bike moving forward");
        }

        public override void backward()
        {
            Console.WriteLine($"{Color} Bike moving backward");
        }

        public override void stop()
        {
            Console.WriteLine($"{Color} Bike stopped");
        }



    }
}
