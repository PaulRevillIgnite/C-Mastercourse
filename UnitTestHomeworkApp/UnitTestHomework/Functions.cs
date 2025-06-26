using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestHomework
{
    public class Functions
    {
        public bool DivisibleBy3(int number)
        {
            int remainder = 0;

            remainder = number % 3;

            Console.WriteLine(remainder);

            if (remainder != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
