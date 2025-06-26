using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanciatedClasses
{
    // Blueprint
    public class PersonModel
    {
        // Example 1
        //public string firstName;
        //public string lastName;
        //public string emailAddress;

        //Example 2 (best practice)
        // To create the below line, type prop and hit tab
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }
    }
}
