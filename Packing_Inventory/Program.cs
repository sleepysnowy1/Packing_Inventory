using Packing_Inventory.Classes;
using Packing_Inventory.Classes.InventoryItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string goAgain = null; 
            Pack playersPack = new Pack();

            do
            {
                Menu.ShowMenu();
                Menu.MakeSelection(playersPack);
                Console.WriteLine("Go again? y/n?");
                goAgain = Console.ReadLine();

                Console.Clear(); 
            }while(goAgain == "y");

            playersPack.ListPackDetails();
        }

    }
}
