using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomework
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    public class Car : LandVehicle
    {
        int numberOfWheels;
    }

    public class Boat : Vehicle
    {
        int boyancy;
    }

    public class Motorcycle : LandVehicle
    {
        int numberOfWheels;
    }

    public class LandVehicle : Vehicle
    {
        
    }

    public class Vehicle
    {
        int speed;
        int numberOfSeats;
        Array[] location;

        public void Move()
        {

        }

        public void Stop()
        {

        }
    }
}
