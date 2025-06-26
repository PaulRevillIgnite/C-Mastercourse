using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypesHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressModel address = new AddressModel();
            address.Number = "16";
            address.Street = "Olwen Crecent";
            address.City = "Stockport";
            address.Postcode = "SK4 5LH";

            Console.WriteLine(address.FullAddress);

            Console.ReadLine();
        }
    }
}
