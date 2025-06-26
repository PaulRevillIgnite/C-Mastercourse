using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelRoomModel room = new HotelRoomModel();

            room.TurnOnAC().SetTemperature(16).OpenBlinds();

            room.TurnOffAC().CloseBlinds();

            "Hello World".PrintToConsole();

            Console.ReadLine();
        }
    }

    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsACOn { get; set; }
        public bool AreBlindsOpen { get; set; }
    }

    public static class ExtensionSamples
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static HotelRoomModel TurnOnAC(this HotelRoomModel room)
        {
            room.IsACOn = true;
            return room;
        }

        public static HotelRoomModel TurnOffAC(this HotelRoomModel room)
        {
            room.IsACOn = false;
            return room;
        }

        public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HotelRoomModel OpenBlinds(this HotelRoomModel room)
        {
            room.AreBlindsOpen = true;
            return room;
        }

        public static HotelRoomModel CloseBlinds(this HotelRoomModel room)
        {
            room.AreBlindsOpen = false;
            return room;
        }
    }
}
