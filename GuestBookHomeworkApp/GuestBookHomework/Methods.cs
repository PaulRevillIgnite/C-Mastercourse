using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookHomeworkMethods
{
    public static class Methods
    {
        public static void Greeting()
        {
            Console.WriteLine("Welcome! ");
            Console.WriteLine();
        }

        public static string GetName()
        {
            Console.Write("Type your your name (type STOP once finished): ");
            string? output = Console.ReadLine();


            return output;
        }

        public static int GetPartySize()
        {
            int output = 0;
            bool isInt = false;
            do
            {
                Console.Write("Type the number in your party: ");
                string? partySizeString = Console.ReadLine();

                isInt = int.TryParse(partySizeString, out output);

                if (!isInt)
                {
                    Console.WriteLine("Please eneter a whole number");
                }
            }
            while (!isInt);

            Console.WriteLine();

            return output;
        }

        public static Dictionary<string, int> CreateGuestbook()
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            bool stop = false;

            do
            {
                string name = Methods.GetName();

                if (name.ToLower() == "stop")
                {
                    stop = true;
                    Console.WriteLine();
                }
                else
                {
                    int partySize = Methods.GetPartySize();
                    output[name] = partySize;
                }
            }
            while (!stop);

            return output;
        }

        public static void PrintGuesbook(Dictionary<string, int> guestBook)
        {
            Console.WriteLine("The guests and there party sizes are:");
            foreach (KeyValuePair<string, int> entry in guestBook)
            {
                Console.WriteLine($"{entry.Key} with {entry.Value} guests.");
            }

            Console.WriteLine();
        }

        public static int TotalNumberOfGuests(Dictionary<string, int> guestBook)
        {
            int output = 0;

            foreach (KeyValuePair<string, int> numberInParty in guestBook)
            {
                output += numberInParty.Value;
            }

            return output;
        }

        public static void DisplayTotalGuests(Dictionary<string, int> guestBook)
        {
            Console.WriteLine($"The total number of guests are the party are {Methods.TotalNumberOfGuests(guestBook)}");
        }
    }
}
