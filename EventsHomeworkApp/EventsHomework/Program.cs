using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarModel car = new CarModel();

            car.EngineStarted += Car_EngineStarted;

            Console.WriteLine(car.IsEngineOn);

            car.StartEngine();

            Console.WriteLine(car.IsEngineOn);

            Console.ReadLine();
        }

        private static void Car_EngineStarted(object sender, string e)
        {
            Console.WriteLine("The engine has started");
            Console.WriteLine(e);
        }
    }

    public class CarModel
    {
        public event EventHandler<string> EngineStarted;

        public bool IsEngineOn { get; set; }

        public void StartEngine()
        {
            IsEngineOn = true;
            EngineStarted.Invoke(this, "The engine is now on");
        }
    }
}
