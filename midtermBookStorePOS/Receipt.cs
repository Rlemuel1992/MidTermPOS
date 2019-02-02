using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Receipt
    {        

        public static void PrintReceipt()
        {
            foreach (Book b in Program.Cart)
            {
                Console.WriteLine(b.Title, b.Author, b.Price);
            }
        }
        //I want foreach here
        //we need a second list 
        //
    }
}
