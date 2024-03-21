using Packing_Inventory.Classes.InventoryItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory.Classes
{
    static internal class Menu
    {
        static public void ShowMenu()
        {
            Console.WriteLine("1: Arrow.");
            Console.WriteLine("2: Bow. ");
            Console.WriteLine("3: Rope");
            Console.WriteLine("4: Water");
            Console.WriteLine("5: Food");
            Console.WriteLine("6: Sword");
            Console.WriteLine("7: Show Contents"); 

        }

        static public Pack MakeSelection(Pack userPack)
        {
            int userChoice; 

            userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {


                case 1:
                    userPack.AddItem(new Arrow());
                    return userPack;
                    

                case 2:
                    userPack.AddItem(new Bow());
                    return userPack;
                    

                case 3:
                    userPack.AddItem(new Rope());
                    return userPack;
                    

                case 4:
                    userPack.AddItem(new Water());
                    return userPack;
                    

                case 5:
                    userPack.AddItem(new Food());
                    return userPack;
                    

                case 6:
                    userPack.AddItem(new Sword());
                    return userPack;

                case 7:
                    userPack.ListPackDetails();
                    return userPack;
                    

                default: return null;

                    
            }
            
        }
    }
}
