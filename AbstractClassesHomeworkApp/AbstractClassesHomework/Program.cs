using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Petable dog = new Dog { Type = "dog"};

            dog.Pet();

            Console.ReadLine();
        }
    }

    public interface Petable
    {
        void Pet();
    }

    public abstract class Animal
    {
        public string Type { get; set; }
    }

    public class Dog : Animal, Petable
    {
        public void Pet()
        {
            Console.WriteLine($"You pet the {Type}");
        }
    }
}
