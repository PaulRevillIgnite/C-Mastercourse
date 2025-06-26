using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public class RequestData
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
        public static double GetDouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();

            double output;

            bool isDouble = double.TryParse(numberText, out output);

            while (isDouble == false)
            {
                Console.WriteLine("That was not a valid number");
                Console.Write(message);
                numberText = Console.ReadLine();

                isDouble = double.TryParse(numberText, out output);
            }

            return output;
        }
    }
}
