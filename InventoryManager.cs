using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
{
    class InventoryManager
    {
       
        InventoryItem[] yourInventory = new InventoryItem[10];
        private int inventoryFinalIndex = 0;

        //example values
        public InventoryManager()
        {
            yourInventory[0] = new InventoryItem("Paper", 15, 19.99m, "Office Supplies");
            yourInventory[1] = new InventoryItem("Pens", 150, .24m, "Office Supplies");
            yourInventory[2] = new InventoryItem("Rug", 10000, 7.99m, "Office Furniture");
            yourInventory[3] = new InventoryItem("Chairs", 15, 99.95m, "Office Furniture");
            yourInventory[4] = new InventoryItem("Coffee", 28, 3.17m, "Food");
            inventoryFinalIndex = 5;
        }

        public void addItem(string itemName, int quantity, decimal itemPrice, string itemCategory)
        {
            yourInventory[inventoryFinalIndex] = new InventoryItem(itemName, quantity, itemPrice, itemCategory);
            inventoryFinalIndex++;
        }

        public void removeItem(int index)
        {
            
            for (int i = 0; (i + index) <= (yourInventory.Length - 1); i++)
            {
                if (index + i == yourInventory.Length - 1)
                {
                    yourInventory[index + i] = null;
                }
                else
                {
                    
                    yourInventory[index + i] = yourInventory[index + i + 1];
                }
            }
            inventoryFinalIndex--;
        }

        public void restockItem(int index, int quantity)
        {
            yourInventory[index].AddItem(quantity);
        }

        //display the whole inventory.
        public void displayInventory()
        {
            for (int i = 0; i < inventoryFinalIndex; i++)
            {
                Console.WriteLine(yourInventory[i].ToString());
            }
        }

        //displays a single item in the inventory.
        public string displaySingleItem(int index)
        {
            return yourInventory[index].ToString();
        }

       
        public int searchInventory(string searchCriteria, string lookingFor)
        {
            switch (searchCriteria)
            {
                case "name":

                    for (int index = 0; index < yourInventory.Length; index++)
                    {
                        if (yourInventory[index].ItemName == lookingFor)
                        {
                            return index;
                        }

                        if (index == yourInventory.Length - 1)
                        {
                            return -1;
                        }
                    }

                    break;

                case "quantity":

                    for (int index = 0; index < yourInventory.Length; index++)
                    {
                        if (yourInventory[index].QuantityOnHand == int.Parse(lookingFor))
                        {
                            return index;
                        }

                        if (index == yourInventory.Length - 1)
                        {
                            return -1;
                        }
                    }

                    break;
            }
            //error
            return -1;
        }
    }
}


