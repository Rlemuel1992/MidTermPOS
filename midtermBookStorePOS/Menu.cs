using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midtermBookStorePOS
{
    class Menu
    {
        public static void DisplayMenu()
        {
            int userNumSelectMenu;
            Console.WriteLine("Please choose a number of the following options:\n");
            Console.WriteLine("1. In Search Of Lost Time By Marcel Proust\n2. Don Quixote By Miguel De Cer3vantes\n3. Ulysses By James Joyce\n4. The Great Gatsby By F.Scott Fitzgerald\n5. Moby Dick By Herman Melville\n6. Hamlet By William Shakespeare\n7. War and Peace By Leo Tolstoy\n8. The Odyssey By Homer\n9. Lolita By Vladimir Nabokov\n10. On the Road By Jack Kerouac\n11. Breakfast of Champions By Kurt Vonnegut\n12. The Alchemist By Paulo Coelho");
            Console.WriteLine("\nPlease enter a menu number");
            userNumSelectMenu = Validation.SelectNum(); //Calling class of validation to select number of book

            if (userNumSelectMenu == Book)
            {

            }
        }
    }
}
