using System;

namespace InheritanceMiniProject
{
    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int NumberOfPages { get; set; }

        public void Purchase()
        {
            QuantityInStock -= 1;
            Console.WriteLine($"{ProductName} has been purchased");
        }
    }
}
