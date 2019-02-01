using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Menu
    {
        public double Price { get; internal set; }

        public static void DisplayMenu()
        {
            List<Book> Books = new List<Book>();
            Book InSearchofLostTime = new Book("In Search of Lost Time", "Marcel Proust", 22.75);
            Book DonQuixote = new Book("Don Quixote", "Miguel de Cervantes", 29.99);
            Book Ulysses = new Book("Ulysses", "James Joyce", 15.95);
            Book TheGreatGatsby = new Book("The Great Gatsby", "F.Scott Fitzgerald", 10.82);
            Book MobyDick = new Book("Moby Dick", "Herman Melville", 9.56);
            Book Hamlet = new Book("Hamlet", "William Shakespeare", 12.95);
            Book WarandPeace = new Book("War and Peace", "Leo Tolstoy", 11.16);
            Book TheOdyssey = new Book("The Odyssey", "Homer", 14.39);
            Book Lolita = new Book("Lolita", "Vladimir Nabokov", 17.00);
            Book OntheRoad = new Book("On the Road", "Jack Kerouac", 14.45);
            Book Breakfastofchampions = new Book("Breakfast of champions", "Kurt Vonnegut", 15.35);
            Book TheAlchemist = new Book("The Alchemist", "Paulo Coelho", 13.89);

            int userNumSelectMenu;
            bool isValidInput = false;

            Console.WriteLine("Please choose a number of the following options:\n");
            Console.WriteLine("1. In Search Of Lost Time By Marcel Proust\n2. Don Quixote By Miguel De Cervantes\n3. Ulysses By James Joyce\n4. The Great Gatsby By F.Scott Fitzgerald\n5. Moby Dick By Herman Melville\n6. Hamlet By William Shakespeare\n7. War and Peace By Leo Tolstoy\n8. The Odyssey By Homer\n9. Lolita By Vladimir Nabokov\n10. On the Road By Jack Kerouac\n11. Breakfast of Champions By Kurt Vonnegut\n12. The Alchemist By Paulo Coelho");
            Console.WriteLine("\nPlease enter a menu number");
            userNumSelectMenu = Validation.SelectNum(); //Calling class of validation to select number of book

            if (userNumSelectMenu == 1)
            {
                Console.WriteLine(InSearchofLostTime);
            }
            else if (userNumSelectMenu == 2)
            {
                Console.WriteLine(DonQuixote);
            }
            else if (userNumSelectMenu == 3)
            {
                Console.WriteLine(Ulysses);
            }
            else if (userNumSelectMenu == 4)
            {
                Console.WriteLine(TheGreatGatsby);
            }
            else if (userNumSelectMenu == 5)
            {
                Console.WriteLine(MobyDick);
            }
            else if (userNumSelectMenu == 6)
            {
                Console.WriteLine(Hamlet);
            }
            else if (userNumSelectMenu == 7)
            {
                Console.WriteLine(WarandPeace);
            }
            else if (userNumSelectMenu == 8)
            {
                Console.WriteLine(TheOdyssey);
            }
            else if (userNumSelectMenu == 9)
            {
                Console.WriteLine(Lolita);
            }
            else if (userNumSelectMenu == 10)
            {
                Console.WriteLine(OntheRoad);
            }
            else if (userNumSelectMenu == 11)
            {
                Console.WriteLine(Breakfastofchampions);
            }
            else if (userNumSelectMenu == 12)
            {
                Console.WriteLine(TheAlchemist);
            }
            else
            {
                Console.WriteLine("That's not between 1-12. Try Again.");
            }
            while (isValidInput) ;
        }
    }
}
