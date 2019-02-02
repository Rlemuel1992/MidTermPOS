using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Program
    {
        private static double grandTotal;

        static void Main(string[] args)
        {           
            Menu.DisplayMenu();
            Checkout.PaymentChoice(grandTotal);
            
        }
    }
}           
