using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathShortcuts
    {
        public static void Add(double x, double y)
        {
            Console.WriteLine($"The value of {x} + {y} = {x + y}");
        }

        public static double AddAll(double[] values)
        {
            double output = 0;

            foreach (double value in values)
            {
                output += value;
            }

            return output;
        }
    }
}
