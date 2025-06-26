using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomework
{
    internal class Methods
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to this Methods homeword program");
            Console.WriteLine("This isn't too bad");
            Console.WriteLine();
        }
        public static string GetName()
        {
            Console.Write("Type your name: ");
            string output = Console.ReadLine();
            Console.WriteLine();

            return output;
        }

        public static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
