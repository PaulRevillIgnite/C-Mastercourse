using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyModel Ignite = new CompanyModel();

            Ignite.Domain = "Ignite.com";

            EmployeeModel employee1 = new EmployeeModel();
            
            employee1.FirstName = "Paul";
            employee1.LastName = "Revill";
            employee1.Email = employee1.GenerateEmail(Ignite, employee1.GenerateIDNumber(Ignite), false);

            Console.WriteLine(employee1.Email);

            EmployeeModel employee2 = new EmployeeModel();
            employee2.GenerateIDNumber(Ignite);
            employee2.FirstName = "Coral";
            employee2.LastName = "Murphy";
            employee2.Email = employee2.GenerateEmail(Ignite, employee1.GenerateIDNumber(Ignite), false);

            Console.WriteLine(employee2.Email);

            EmployeeModel employee3 = new EmployeeModel();
            employee3.GenerateIDNumber(Ignite);
            employee3.FirstName = "Alan";
            employee3.LastName = "Davies";
            employee3.Email = employee3.GenerateEmail(Ignite, true);

            Console.WriteLine(employee3.Email);

            EmployeeModel employee4 = new EmployeeModel();
            employee4.GenerateIDNumber(Ignite);
            employee4.Email = employee4.GenerateEmail(Ignite);

            Console.WriteLine(employee4.Email);

            Console.ReadLine();
        }
    }

    public class CompanyModel
    {
        public int CurrentID = 1;
        public string Domain { get; set; }
    }

    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IDNumber { get; set; }
        public string Email { get; set; }

        public string GenerateIDNumber(CompanyModel company)
        {
            IDNumber = company.CurrentID;

            company.CurrentID = company.CurrentID + 1;

            return IDNumber.ToString();
        }

        public string GenerateEmail(CompanyModel company)
        {
            return GenerateEmail(company, "999", false);
        }

        public string GenerateEmail(CompanyModel company, bool contractor)
        {
            return GenerateEmail(company, "", true);
        }

        public string GenerateEmail(CompanyModel company, string id, bool contractor)
        {
            if (id == "999")
            {
                return $"test.test@{company.Domain}";
            }

            if (contractor == true)
            {
                return $"{FirstName}.{LastName}.Contractor@{company.Domain}";
            }
            else
            {
                return $"{FirstName}.{LastName}.{IDNumber}@{company.Domain}";
            }
        }
    }
}
