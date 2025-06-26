using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypes
{
    public class PersonModel
    {
        //Can be set but not read
        public string firstName { private get; set; }

        //Can be read but not set
        public string LastName { get; private set; }

        private int _password;

        public int Password
        {
            set { _password = value; }
        }

        public string FullName
        {
            get
            {
                return $"{firstName} {LastName}";
            }
        }

        //public string age { get; set; }

        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age is too low or too high.");
                }
            }
        }

        //public string NINumber { get; set; } // National insurance number 123-45-6789

        private string _NINumber;

        public string NINumber
        {
            get
            {
                string output = "***-**-" + _NINumber.Substring(_NINumber.Length - 4);
                return output;
            }
            set
            {
                _NINumber = value;
            }
        }

        public PersonModel()
        {
               
        }

        public PersonModel(string lastName)
        {
            LastName = lastName;
        }
    }
}
