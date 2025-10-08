using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_LambdaHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataQueries();

            Console.WriteLine("\nDone Processing");
            Console.ReadLine();
        }

        public static void DataQueries()
        {
            var people = SampleData.GetContactData();

            var results = people.Where(p => p.LastName == "Revill");
            Console.WriteLine("People with a lastname of Revill:");
            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
            }

            var results2 = people.Where(p => p.Age > 20);
            Console.WriteLine("\nPeople over 20 years old:");
            foreach (var item in results2)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
            }

            var results3 = (from p in people
                            where p.FirstName == "Coral"
                            select p);
            Console.WriteLine("\nPeople with a firstname of Coral:");
            foreach (var item in results3)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
            }
        }
    }
}
