﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypesHomework
{
    public class AddressModel
    {
        public string Number { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Postcode { get; set; }

        private string _FullAddress;

        public string FullAddress
        {
            get { return Number + "\n" + Street + "\n" + City + "\n" + Postcode; }
        }


    }
}
