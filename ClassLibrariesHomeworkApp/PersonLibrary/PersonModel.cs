﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
