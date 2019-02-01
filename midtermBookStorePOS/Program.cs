using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.DisplayMenu();
            Checkout.GrandTotal();
        }
    }
}
            //List<Book> Books = new List<Book>();
            //Book InSearchofLostTime = new Book("In Search of Lost Time", "Marcel Proust", 00);
            //Book DonQuixote = new Book("Don Quixote", "Miguel de Cervantes", 01);
            //Book Ulysses = new Book("Ulysses", "James Joyce", 02);
            //Book TheGreatGatsby = new Book("The Great Gatsby", "F.Scott Fitzgerald", 03);
            //Book MobyDick = new Book("Moby Dick", "Herman Melville", 04);
            //Book Hamlet = new Book("Hamlet", "William Shakespeare", 05);
            //Book WarandPeace = new Book("War and Peace", "Leo Tolstoy", 06);
            //Book TheOdyssey = new Book("The Odyssey", "Homer", 07);
            //Book Lolita = new Book("Lolita", "Vladimir Nabokov", 08);
            //Book OntheRoad = new Book("On the Road", "Jack Kerouac", 09);
            //Book Breakfastofchampions = new Book("Breakfast of champions", "Kurt Vonnegut", 10);
            //Book TheAlchemist = new Book("The Alchemist", "Paulo Coelho", 11);
