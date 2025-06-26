using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Enter your firstname: ".RequestString();

            person.LastName = "Enter your lastname: ".RequestString();

            person.Age = "Enter your age: ".RequestInt(0, 120);

            Console.ReadLine();
        }
    }
}
