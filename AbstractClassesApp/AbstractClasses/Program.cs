using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.YearOfManufacture = 1992;

            Console.WriteLine(car.NumberOfWheels);

            Console.ReadLine();
        }
    }

    public abstract class VehicleModel
    {
        public string VIN { get; set; }
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public int YearOfManufacture { get; set; }
    }

    public class Car : VehicleModel
    {
        public int NumberOfWheels { get; set; } = 4;
    }
}
