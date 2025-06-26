using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.WriteLine($"Welcome to the App {firstName}");

            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good morning {firstName}");
            }
            if (hourOfDay < 19)
            {
                Console.WriteLine($"Good evening {firstName}");
            }
            else
            {
                Console.WriteLine($"Good night {firstName}");
            }
        }

        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
