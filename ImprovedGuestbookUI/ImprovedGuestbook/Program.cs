using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GuestbookLibrary.Models;

namespace ImprovedGuestbook
{
    internal class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
            GetGuestInfo();

            PrintGuestInfo();

            Console.ReadLine();
        }

        private static void GetGuestInfo()
        {
            string MoreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("Enter your firstname: ");
                guest.LastName = GetInfoFromConsole("Enter your lastname: ");
                guest.MessageToHost = GetInfoFromConsole("Enter a message to your host: ");
                MoreGuestsComing = GetInfoFromConsole("Are more guests coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();
            }
            while (MoreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }

        private static void PrintGuestInfo()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }
    }
}
