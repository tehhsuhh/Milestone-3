using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InventoryManager abc = new InventoryManager();

            Console.WriteLine("Inventory: ");
            abc.displayInventory();

            abc.removeItem(2);

            Console.WriteLine("\nInventory after removing an item: ");
            abc.displayInventory();

            Console.WriteLine("\nRestock of Pens: ");
            abc.restockItem(0, 10);
            abc.displayInventory();

            Console.WriteLine("\nSearching for Desk Chairs: ");
            Console.WriteLine("\nThe following was returned after searching \"Chairs\":");
            Console.WriteLine(abc.displaySingleItem(abc.searchInventory("name", "Chairs")));

            Console.WriteLine("\nSearching for items with a quantity of 28: ");
            Console.WriteLine("\nThe following was returned after searching \"Quantity of 28\":");
            Console.WriteLine(abc.displaySingleItem(abc.searchInventory("quantity", "28")));

            Console.ReadLine();
        }
    }
}
