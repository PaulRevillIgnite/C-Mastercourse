using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class SampleMethods
    {
        public static (string firstName, string lastName) GetFullName()
        {
            Console.Write("What is your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            string lastName = Console.ReadLine();

            return (firstName, lastName);
        }
        public static void SayHi(string firstName)
        {
            Console.WriteLine($"Hi {firstName}");
            Console.WriteLine("I hope you've been well");
        }

        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
            Console.WriteLine("I can't wait to see you again");
        }

        public static string GetUsersName()
        {
            Console.Write("Type your name: ");
            string name = Console.ReadLine();

            return name;
        }
    }
}
