using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolejka
{
    internal class Zamowienie
    {
        public int OrderID {get; set;}
        public int OrderQuantity { get; set;}
        public int ProductID { get; set;}

        public Zamowienie()
        {
        }
        public Zamowienie(int OrderID)
        {
            this.OrderID = OrderID;
        }
        public Zamowienie(int OrderID, int OrderQuantity)
        {
            this.OrderID = OrderID;
            this.OrderQuantity = OrderQuantity;
        }
        public Zamowienie(int OrderID, int OrderQuantity, int ProductID)
        {
            this.OrderID = OrderID;
            this.OrderQuantity = OrderQuantity;
            this.ProductID = ProductID;
        }
        public void PrzetworzZamowienie() 
        {
            Console.WriteLine($"Zamówiono {OrderQuantity}x {ProductID}");
            Console.WriteLine($"Przetworzono Zamówienie #{OrderID}!");
        }
    }
}
