using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationInfo.Calculator;
using Namespaces.Models;

namespace Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            Calculations.Add(2, 5);

            Console.ReadLine();
        }
    }
}
