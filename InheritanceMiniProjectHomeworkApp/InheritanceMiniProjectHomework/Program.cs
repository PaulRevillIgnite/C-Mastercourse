using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceMiniProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            new FishModel { Type = "Fish", Age = 3, TankSize = "Small", VetRegistered = false, Quantity = 1 };

            FishModel fish = new FishModel();

            Console.ReadLine();
        }
    }

    public interface Petable
    {
        string Petable { get; set; }
    }

    public interface Purchable
    {
        void Purchaseable();
    }

    public class PetModel : Purchable
    {
        public string Type { get; set; }
        public int Age { get; set; }
        public bool VetRegistered { get; set; }
        public int Quantity { get; set; }

        public void Purchaseable()
        {
            Console.Write($"Would you like to buy a {Type} (yes/no)?");
            string wantToBuy = Console.ReadLine().ToLower();

            if (wantToBuy == "yes")
            {
                Quantity -= 1;
            }
        }

        public void RegisterForVet()
        {
            Console.Write("Would you like to register with a vet (yes/no): ");
            string wantToRegister = Console.ReadLine().ToLower();

            if (wantToRegister == "yes")
            {
                VetRegistered = true;
            }
        }
    }

    public class FishModel : PetModel
    {
        public string TankSize { get; set; }
    }

    public class BirdModel : PetModel
    {
        public int WingSpan { get; set; }
    }

    public class DogModel : PetModel, Petable
    {
        public string Groomed{ get; set; }
        public string Petable { get; set; }
    }
}
