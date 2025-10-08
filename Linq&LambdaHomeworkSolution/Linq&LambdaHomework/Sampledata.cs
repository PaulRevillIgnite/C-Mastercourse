using Linq_LambdaHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_LambdaHomework
{
    public static class SampleData
    {
        public static List<PersonModel> GetContactData()
        {
            List<PersonModel> output = new List<PersonModel>
            {
                new PersonModel { Id = 1, FirstName = "Paul", LastName = "Revill", Age = 33 },
                new PersonModel { Id = 2, FirstName = "Coral", LastName = "Murphy", Age = 40 },
                new PersonModel { Id = 3, FirstName = "Joe", LastName = "Burns", Age = 66 },
                new PersonModel { Id = 4, FirstName = "Michael", LastName = "Dean", Age = 9 }
            };

            return output;
        }
    }
}
