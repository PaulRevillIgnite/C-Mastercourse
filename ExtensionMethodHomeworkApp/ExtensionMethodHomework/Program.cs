using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Paul";
            person.LastName = "Revill";

            Console.WriteLine(person.setDefaultAge().PrintInfo());

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public static class ExtensionMethods
    {
        public static PersonModel setDefaultAge (this PersonModel person)
        {
            person.Age = 32;
            return person;
        }

        public static string PrintInfo(this PersonModel person)
        {
            return $"Firstname: {person.FirstName}\nLastname: {person.LastName}\nAge: {person.Age}";
        }
    }
}
