﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace midtermBookStorePOS
{
	class Program
	{
		
		static void Main(string[] args)
        {
			PaymentValidation payValidation = new PaymentValidation();
			Checkout checkout = new Checkout();
			string finalAnswer = "y";
			while (finalAnswer == "y")
			{
				checkout = DisplayMenu(checkout);
				checkout.PaymentChoice(checkout.GrandTotal);
				PrintReceipt(checkout, checkout.GrandTotal, checkout.Tax, checkout.SubTotal);
				Console.WriteLine("Would you like to make another transaction? y/n");
				finalAnswer = Console.ReadLine().ToLower();
				if (finalAnswer == "y")
				{
					checkout.SubTotal = 0;
					checkout.Tax = 0;
					checkout.GrandTotal = 0;
					checkout.Cart.Clear();
					continue;
				}
				else if (finalAnswer == "n")
				{
					Console.WriteLine("Have a great day!");
					Environment.Exit(1);
				}
			}

		}
		public static Checkout DisplayMenu(Checkout c)
		{
			List<Book> Books = new List<Book>();
			Book b = new Book();
			int num = 1;

			Book InSearchofLostTime = new Book("In Search of Lost Time", "Marcel Proust", 22.75, 0);
			Books.Add(InSearchofLostTime);
			Book DonQuixote = new Book("Don Quixote", "Miguel de Cervantes", 29.99, 0);
			Books.Add(DonQuixote);
			Book Ulysses = new Book("Ulysses", "James Joyce", 15.95, 0);
			Books.Add(Ulysses);
			Book TheGreatGatsby = new Book("The Great Gatsby", "F.Scott Fitzgerald", 10.82, 0);
			Books.Add(TheGreatGatsby);
			Book MobyDick = new Book("Moby Dick", "Herman Melville", 9.56, 0);
			Books.Add(MobyDick);
			Book Hamlet = new Book("Hamlet", "William Shakespeare", 12.95, 0);
			Books.Add(Hamlet);
			Book WarandPeace = new Book("War and Peace", "Leo Tolstoy", 11.16, 0);
			Books.Add(WarandPeace);
			Book TheOdyssey = new Book("The Odyssey", "Homer", 14.39, 0);
			Books.Add(TheOdyssey);
			Book Lolita = new Book("Lolita", "Vladimir Nabokov", 17.00, 0);
			Books.Add(Lolita);
			Book OntheRoad = new Book("On the Road", "Jack Kerouac", 14.45, 0);
			Books.Add(OntheRoad);
			Book Breakfastofchampions = new Book("Breakfast of champions", "Kurt Vonnegut", 15.35, 0);
			Books.Add(Breakfastofchampions);
			Book TheAlchemist = new Book("The Alchemist", "Paulo Coelho", 13.89, 0);
			Books.Add(TheAlchemist);




			Console.WriteLine("Please choose a number of the following options:\n");

			for (int i = 0; i < Books.Count; i++)
			{
				Console.WriteLine(num + ". " + Books[i].Title);
				num++;
			}
			bool moreBooks = true;
			while (moreBooks == true)
			{
				Console.WriteLine("\nPlease enter a menu number");
				int.TryParse(Console.ReadLine(), out int userNumSelectMenu);
				if (userNumSelectMenu > 0 && userNumSelectMenu <= Books.Count)
				{
					Console.WriteLine("Title: " + Books[userNumSelectMenu - 1].Title);
					Console.WriteLine("Author: " + Books[userNumSelectMenu - 1].Author);
					Console.WriteLine("$" + Books[userNumSelectMenu - 1].Price);
					c.Cart.Add(Books[userNumSelectMenu - 1]);
					bool getQuantity = true;
					while (getQuantity == true)
					{
						Console.WriteLine("Please input the amount of books you'd like to order.");
						int.TryParse(Console.ReadLine(), out int quantityValidate);
						if (quantityValidate <= 0)
						{
							Console.WriteLine("Wrong input!");
							getQuantity = true;
						}
						else
						{
							c.Cart[c.Cart.Count - 1].Quantity = quantityValidate;
							getQuantity = false;
						}

					}
					string keepShopping = "t";
					while (!keepShopping.Equals("n") && !keepShopping.Equals("y"))
					{

						Console.WriteLine("Would you like to add more books on? y/n");
						keepShopping = Console.ReadLine().ToLower();

					}
					if (keepShopping == "y")
					{
						string booksAgain = "t";
						while (!booksAgain.Equals("n") && !booksAgain.Equals("y"))
						{
							Console.WriteLine("Would you like to display the list again? y/n");
							booksAgain = Console.ReadLine().ToLower();
						}
						if (booksAgain == "y")
						{
							num = 1;
							for (int i = 0; i < Books.Count; i++)
							{
								Console.WriteLine(num + ". " + Books[i].Title);
								num++;
								moreBooks = true;
							}
						}
						else if (booksAgain == "n")
						{
							moreBooks = true;
						}
						
					}
					else if (keepShopping == "n")
					{
						moreBooks = false;
						c.CalculatingCost();
						break;

					}
					else
					{
						Console.WriteLine("Wrong input!");
						
					}
				}
				else
				{
					Console.WriteLine("That's not between 1-12. Try Again.");
				}

			}
			return c;
		}
		public static void PrintReceipt(Checkout c, double gt, double tax, double st)
		{

			foreach (Book b in c.Cart)
			{
				
				Console.WriteLine($"Title: {b.Title} \t\t{b.Quantity} at ${b.Price}");
				Console.WriteLine($"	By {b.Author}");
				Console.WriteLine();
				
			}
			Console.WriteLine("\n\n");
			tax = c.GrandTotal - c.SubTotal;
			Console.WriteLine($"Subtotal: {c.SubTotal}");
			Console.WriteLine($"Tax: {Math.Round(tax, 2)}");
			Console.WriteLine($"Grand Total: {Math.Round(c.GrandTotal,2)}");
			Console.WriteLine("Thank you for shopping at ConsoleReadLine(YourBooks)\n\n");
			
		}

	}
}           
