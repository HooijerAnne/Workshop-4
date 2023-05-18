using Workshop_4.Models;

namespace Workshop_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a red bike instance
            Bike redBike = new Bike("Red");
            redBike.forward();

            // Creating a yellow bike instance
            Bike yellowBike = new Bike("Yellow");
            yellowBike.backward();

            // Creating a blue bike instance
            Bike blueBike = new Bike("Blue");
            blueBike.stop();

            // Creating a red car instance
            Car redCar = new Car("Red");
            redCar.forward();

            // Creating a yellow car instance
            Car yellowCar = new Car("Yellow");
            yellowCar.turnOn();

            // Creating a blue car instance
            Car blueCar = new Car("Blue");
            blueCar.turnOff();

            // Creating a red truck instance
            Truck redTruck = new Truck("Red");
            redTruck.forward();

            // Creating a yellow truck instance
            Truck yellowTruck = new Truck("Yellow");
            yellowTruck.load();
            yellowTruck.turnOff();

            // Creating a blue truck instance
            Truck blueTruck = new Truck("Blue");
            blueTruck.turnOn();

            // Creating a Airbus Plane instance
            Plane Airbus = new Plane("Airbus");
            Airbus.takingOff();

            // Creating a Boeing Plane instance
            Plane Boeing = new Plane("Boeing");
            Boeing.landing();

            // Creating a Falcon Plane instance
            Plane Falcon = new Plane("Falcon");
            Falcon.turnOff();

            // Creating a redCargoPlane instance
            CargoPlane redCargoPlane = new CargoPlane("Red");
            redCargoPlane.load();

            // Creating a yellowCargoPlane instance
            CargoPlane yellowCargoPlane = new CargoPlane("Yellow");
            yellowCargoPlane.takingOff();

            // Creating blueCargoPlane instance
            CargoPlane blueCargoPlane = new CargoPlane("Blue");
            blueCargoPlane.landing();

        }
    }
}