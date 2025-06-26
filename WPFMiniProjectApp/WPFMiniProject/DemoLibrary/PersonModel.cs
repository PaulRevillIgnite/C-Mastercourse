using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMiniProject.DemoLibrary;

namespace WPFMiniProject
{
    class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel Address { get; set; }
        public string AddressString => $"{Address.HouseNumber} {Address.Postcode}";

    }
}
