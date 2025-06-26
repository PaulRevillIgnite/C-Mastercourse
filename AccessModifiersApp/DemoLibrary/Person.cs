using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Person
    {
        protected string FormerLastName = "";
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private string _niNumber;

        public string NINumber
        {
            get 
            {
                return $"***-***-{_niNumber.Substring(_niNumber.Length - 4)}";
            }
            set
            {
                _niNumber = value;
            }
        }

        public void ChangeLastName(String newLastName)
        {
            FormerLastName = LastName;
            LastName = newLastName;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName}");
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess();
            string connection = data.GetConnectionString();
            // Saves the person
        }
    }
}
