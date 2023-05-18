using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_4.Interfaces;

namespace Workshop_4.Models
{
    public abstract class Vehicle : iDrive
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract void forward();
        public abstract void backward();
        public abstract void stop();
    }
}
