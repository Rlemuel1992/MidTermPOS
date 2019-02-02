using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Menu
    {                           //Rudy-Add descriptions of books

        public double Price { get; internal set; }


        public static void DisplayMenu()
        {
            List<Book> Books = new List<Book>();
            Book InSearchofLostTime = new Book("In Search of Lost Time", "Marcel Proust", 22.75,0);
            Books.Add(InSearchofLostTime);
            Book DonQuixote = new Book("Don Quixote", "Miguel de Cervantes", 29.99,0);
            Books.Add(DonQuixote);
            Book Ulysses = new Book("Ulysses", "James Joyce", 15.95,0);
            Books.Add(Ulysses);
            Book TheGreatGatsby = new Book("The Great Gatsby", "F.Scott Fitzgerald", 10.82,0);
            Books.Add(TheGreatGatsby);
            Book MobyDick = new Book("Moby Dick", "Herman Melville", 9.56,0);
            Books.Add(MobyDick);
            Book Hamlet = new Book("Hamlet", "William Shakespeare", 12.95,0);
            Books.Add(Hamlet);
            Book WarandPeace = new Book("War and Peace", "Leo Tolstoy", 11.16,0);
            Books.Add(WarandPeace);
            Book TheOdyssey = new Book("The Odyssey", "Homer", 14.39,0);
            Books.Add(TheOdyssey);
            Book Lolita = new Book("Lolita", "Vladimir Nabokov", 17.00,0);
            Books.Add(Lolita);
            Book OntheRoad = new Book("On the Road", "Jack Kerouac", 14.45,0);
            Books.Add(OntheRoad);
            Book Breakfastofchampions = new Book("Breakfast of champions", "Kurt Vonnegut", 15.35,0);
            Books.Add(Breakfastofchampions);
            Book TheAlchemist = new Book("The Alchemist", "Paulo Coelho", 13.89,0);
            Books.Add(TheAlchemist);

            int userNumSelectMenu;
            bool isValidInput = false;
            int quantity = 0;
            Checkout c = new Checkout(quantity);
            bool toMenu = true;

            while (toMenu == true)
            {
                Console.WriteLine("Please choose a number of the following options:\n");
                Console.WriteLine("1. In Search Of Lost Time By Marcel Proust\n2. Don Quixote By Miguel De Cervantes\n3. Ulysses By James Joyce\n4. The Great Gatsby By F.Scott Fitzgerald\n5. Moby Dick By Herman Melville\n6. Hamlet By William Shakespeare\n7. War and Peace By Leo Tolstoy\n8. The Odyssey By Homer\n9. Lolita By Vladimir Nabokov\n10. On the Road By Jack Kerouac\n11. Breakfast of Champions By Kurt Vonnegut\n12. The Alchemist By Paulo Coelho");
                Console.WriteLine("\nPlease enter a menu number");
                userNumSelectMenu = Validation.SelectNum(); //Calling class of validation to select number of book

                if (userNumSelectMenu == 1)
                {
                    Console.WriteLine(InSearchofLostTime.Title + ", " + InSearchofLostTime.Author + ", $" + InSearchofLostTime.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(InSearchofLostTime);
                    InSearchofLostTime.Price = Checkout.Price;
                    toMenu = true;
                }
                else if (userNumSelectMenu == 2)
                {
                    Console.WriteLine(DonQuixote.Title + ", " + DonQuixote.Author + ", $" + DonQuixote.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(DonQuixote);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 3)
                {
                    Console.WriteLine(Ulysses.Title + ", " + Ulysses.Author + ", $" + Ulysses.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(Ulysses);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 4)
                {
                    Console.WriteLine(TheGreatGatsby.Title + ", " + TheGreatGatsby.Author + ", $" + TheGreatGatsby.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(TheGreatGatsby);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 5)
                {
                    Console.WriteLine(MobyDick.Title + ", " + MobyDick.Author + ", $" + MobyDick.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(MobyDick);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 6)
                {
                    Console.WriteLine(Hamlet.Title + ", " + Hamlet.Author + ", $" + Hamlet.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(Hamlet);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 7)
                {
                    Console.WriteLine(WarandPeace.Title + ", " + WarandPeace.Author + ", $" + WarandPeace.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(WarandPeace);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 8)
                {
                    Console.WriteLine(TheOdyssey.Title + ", " + TheOdyssey.Author + ", $" + TheOdyssey.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(TheOdyssey);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 9)
                {
                    Console.WriteLine(Lolita.Title + ", " + Lolita.Author + ", $" + Lolita.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(Lolita);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 10)
                {
                    Console.WriteLine(OntheRoad.Title + ", " + OntheRoad.Author + ", $" + OntheRoad.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(OntheRoad);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 11)
                {
                    Console.WriteLine(Breakfastofchampions.Title + ", " + Breakfastofchampions.Author + ", $" + Breakfastofchampions.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(Breakfastofchampions);
                    toMenu = true;
                }
                else if (userNumSelectMenu == 12)
                {
                    Console.WriteLine(TheAlchemist.Title + ", " + TheAlchemist.Author + ", $" + TheAlchemist.Price);
                    Console.WriteLine("Please input the amount of books you'd like to order.");
                    quantity = int.Parse(Console.ReadLine());
                    Program.Cart.Add(TheAlchemist);
                    toMenu = true;
                }
                else
                {
                    Console.WriteLine("That's not between 1-12. Try Again.");
                }
                while (isValidInput);
                toMenu = backToMenu();
            }
        }
        public static bool backToMenu()
        {
            Console.WriteLine("\nWould you like to return to the Menu or proceed to Checkout?(Menu or Checkout)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "menu")
            {
                goOn = true;
            }
            else if (input == "checkout")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = backToMenu();
            }
            return goOn;
        }
    }
}