using DemoLibrary;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
// https://www.w3schools.com/cs/cs_access_modifiers.php

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.SavePerson();

            Console.ReadLine();
        }
    }
}
