using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Book
    {
        public Book()
        {

        }
        public Book(string title, string author, double price)
        {
            Price = price;
            Title = title;
            Author = author;
        }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        }
}
