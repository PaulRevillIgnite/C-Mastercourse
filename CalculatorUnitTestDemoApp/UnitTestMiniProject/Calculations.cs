using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary
{
    public class Calculations
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double subtract(double x, double y)
        {
            return x - y;
        }

        public double multiply(double x, double y)
        {
            return x * y;
        }

        public double divide(double x, double y)
        {
            double output = 0;

            if (y != 0)
            {
                output = x / y;
            }

            return output;
        }
    }
}
