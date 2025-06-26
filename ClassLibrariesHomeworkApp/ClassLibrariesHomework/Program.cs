using PersonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrariesHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            Console.Write("What is your firstname: ");
            person.FirstName = Console.ReadLine();

            person.LastName = "Revill";

            Console.WriteLine(person.GetFullName());

            Console.ReadLine();
        }
    }
}
