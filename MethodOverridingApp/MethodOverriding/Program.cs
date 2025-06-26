using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "Paul",
                LastName = "Revll",
                Email = "paul_revs@hotmail.com"
            };

            Console.WriteLine(person);

            Console.ReadLine();
        }
    }
}
