using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Checkout
    {
        public Menu Item { get; set; }
        public int Quantity { get; set; }
        private readonly double taxRate = 0.06;

        public Checkout()
        {
        }

        public Checkout(Menu item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }

        public double SubTotal()
        {
            double subTotal = Item.Price * Quantity;
            return subTotal;
        }

        public double SalesTaxTotal()
        {
            double subTotal = SubTotal();
            double tax = subTotal * taxRate;
            return tax;
        }

        public double GrandTotal()
        {
            double subTotal = SubTotal();
            double tax = SalesTaxTotal();
            double grandTotal = subTotal + tax;
            return grandTotal;
        }
    }
}
