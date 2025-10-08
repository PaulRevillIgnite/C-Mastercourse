using LinqUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LambdaTests();
            LinqTests();

            Console.WriteLine("\nDone Processing");
            Console.ReadLine();
        }

        private static void LinqTests()
        {
            var contacts = SampleData.GetContactData();
            var addresses = SampleData.GetAddressData();

            //var results = (from c in contacts
            //               where c.Address.Count > 1
            //               select c);

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}

            //var results = (from c in contacts
            //               join a in addresses on c.Id equals a.ContactId
            //               select new {c.FirstName, c.LastName, a.City, a.State});

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} from {item.City}, {item.State}");
            //}

            //var results = (from c in contacts
            //               select new { c.FirstName, c.LastName, Addresses = addresses.Where(a => a.ContactId == c.Id) });

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()}");
            //}

            var results = (from c in contacts
                           select new { c.FirstName, c.LastName, Addresses = addresses.Where(a => c.Address.Contains(a.Id)) });

            foreach (var item in results)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} - {item.Addresses.Count()}");
            }
        }

        private static void LambdaTests()
        {
            var data = SampleData.GetContactData();

            //var results = data.Where(c => c.Address.Count > 1);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}

            //var results = data.Select(x => x.FirstName);
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item);
            //}

            //var results = data.Take(2);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}

            //var results = data.Skip(2).Take(2);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}

            //var results = data.OrderBy(x => x.LastName);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}

            //var results = data.OrderByDescending(x => x.LastName);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName}");
            //}
        }

        /*This line:
            var results = data.Where(x => x.Address.Count > 1);

        Is kinda the same as this method:
            private static bool RunMe(ContactModel x)
            {
                if (x.Address.Count > 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }*/
    }
}
