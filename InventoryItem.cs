using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
    // written by Tessa Biava for CST-117
{
    class InventoryItem
    {
        public int ItemID { get; }
        public string ItemName { get; set; }
        public int QuantityOnHand { get; set; }
        public int QuantityOnOrder { get; set; } = 0;
        public decimal ItemPrice { get; set; }
        public string ItemCategory { get; set; }
        private static int totalInventoryQuantity = 1; 

        //constructor
        public InventoryItem(string itemName, int quantityOnHand, decimal itemPrice, string itemCategory)
        {
            ItemName = itemName;
            QuantityOnHand = quantityOnHand;
            ItemPrice = itemPrice;
            ItemCategory = itemCategory;
            ItemID = totalInventoryQuantity;
            totalInventoryQuantity++;
        }

        //methods
        public void OrderItems(int howMany)
        {
            QuantityOnOrder += howMany;
        }

        public void RemoveItem(int howMany)
        {
            QuantityOnHand -= howMany;
        }

        public void AddItem(int howMany)
        {
            QuantityOnHand += howMany;
        }

        public new string ToString()
        {
            return ItemName + " " + QuantityOnHand + " " + ItemCategory;
        }
    }
}
