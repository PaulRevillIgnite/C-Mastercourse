using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRun> runners = new List<IRun>();
            Person Paul = new Person();
            Animal Dog = new Animal();

            runners.Add(Paul);
            runners.Add(Dog);
        }
    }
}
