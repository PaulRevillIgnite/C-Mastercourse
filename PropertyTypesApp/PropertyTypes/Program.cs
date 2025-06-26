using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Revill");

            person.firstName = "Paul";
            //person.LastName = "Revill";
            person.Age = 32;
            person.NINumber = "123-45-6789";

            Console.WriteLine(person.FullName);

            Console.WriteLine(person.NINumber);

            Console.ReadLine();
        }
    }
}
