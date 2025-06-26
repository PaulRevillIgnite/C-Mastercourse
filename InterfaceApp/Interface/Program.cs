using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // Interface is a contract
    // Classes implement interfaces

    class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredGameController ps3 = new BatteryPoweredGameController();
            BatteryPoweredKeyboard batteryPoweredKeyboard = new BatteryPoweredKeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(ps3);

            foreach (IComputerController controller in controllers)
            {
                if (controller is GameController gc)
                {
                    gc.Connect();
                }

                if (controller is IBatteryPowered powered)
                {
                    controller.CurrentKeyPressed();
                    powered.BatteryLevel = 50;
                }
            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();

            powereds.Add(ps3);
            powereds.Add(batteryPoweredKeyboard);

            Console.ReadLine();
        }
    }

    public interface IComputerController : IDisposable
    {
        void Connect();
        void CurrentKeyPressed();
    }

    public class Keyboard : IComputerController
    {
        public void Connect()
        {

        }

        public void CurrentKeyPressed()
        {

        }

        public void Dispose()
        {
            
        }

        public string ConnectionType { get; set; }
    }

    public interface IBatteryPowered
    {
        int BatteryLevel { get; set; }
    }

    public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }

    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {
            
        }

        public void CurrentKeyPressed()
        {
            
        }

        public void Dispose()
        {
            // Do shutdown tasks
        }

        
    }

    public class BatteryPoweredGameController : GameController, IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }
}
