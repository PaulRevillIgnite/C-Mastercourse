using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesHomework
{
    public static class UserMessage
    {
        public static double GetNumber(string message)
        {
            double output = 0;
            bool isNumber = false;

            do
            {
                Console.Write(message);
                string numberText = Console.ReadLine();

                isNumber = double.TryParse(numberText, out output);
            }
            while (!isNumber);

            Console.WriteLine();
                    
            return output;
        }

        public static void CommunicateWithUser(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
        }
    }
}
