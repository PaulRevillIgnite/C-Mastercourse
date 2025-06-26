using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsMiniProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Enter your first name:".GetString();
            person.LastName = "Enter your last name:".GetString();
            person.Age = "Enter your age:".GetInt();

            Console.WriteLine($"{person.FirstName} {person.LastName} {person.Age.ToString()}");

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public static class ConsoleHelper
    {
        public static string GetString(this string message)
        {
            string output = "";

            while (String.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int GetInt(this string message)
        {
            string input = "";
            bool isValidInt = int.TryParse(input, out int output);

            while (!isValidInt)
            {
                Console.Write(message);
                input = Console.ReadLine();
                isValidInt = int.TryParse(input, out output);
            }

            return output;
        }
    }
}
