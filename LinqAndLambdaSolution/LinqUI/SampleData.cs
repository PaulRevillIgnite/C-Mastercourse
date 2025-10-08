using LinqUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUI
{
    public static class SampleData
    {
        public static List<ContactModel> GetContactData()
        {
            List<ContactModel> output = new List<ContactModel>
            {
                new ContactModel{Id = 1, FirstName = "Paul", LastName = "Revill", Address = new List<int>{1, 2, 3,}},
                new ContactModel{Id = 2, FirstName = "Coral", LastName = "Murphy", Address = new List<int>{1,}},
                new ContactModel{Id = 3, FirstName = "Joe", LastName = "Burns", Address = new List<int>{2,}},
                new ContactModel{Id = 4, FirstName = "Michael", LastName = "Dean", Address = new List<int>{3,}},
                new ContactModel{Id = 5, FirstName = "Lloyd", LastName = "Chadwick", Address = new List<int>{2, 3,}}
            };

            return output;
        }

        public static List<AddressModel> GetAddressData()
        {
            List<AddressModel> output = new List<AddressModel>
            {
                new AddressModel{Id = 1, ContactId = 1, City = "Stockport", State = "GM" },
                new AddressModel{Id = 2, ContactId = 1, City = "Leeds", State = "YS" },
                new AddressModel{Id = 3, ContactId = 2, City = "Wolves", State = "BH" },
                new AddressModel{Id = 4, ContactId = 5, City = "Stockport", State = "GM" },
                new AddressModel{Id = 5, ContactId = 5, City = "Leeds", State = "YS" },
                new AddressModel{Id = 6, ContactId = 4, City = "Leeds", State = "YS" },
                new AddressModel{Id = 7, ContactId = 3, City = "Wolves", State = "BH" }
            };

            return output;
        }
    }
}
