using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = PrintObject("test");
            Console.WriteLine(output);

            output = PrintObject(123);
            Console.WriteLine(output);

            output = PrintObject(true);
            Console.WriteLine(output);

            Console.ReadLine();
        }

        private static String PrintObject<T>(T item)
        {
            string output = "";
            output = item.ToString();

            return output;
        }
    }
}
