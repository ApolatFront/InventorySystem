using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class InventoryHandling
    {
        private Dictionary<string, int> items;

        public InventoryHandling() {
            items = new Dictionary<string, int>();
        }

        public void AddItem(string itemName, int quantity = 1)
        {
            if (items.ContainsKey(itemName))
            {
                items[itemName] += quantity;
            }
            else
            {
                items[itemName] = quantity;
            }
            Console.WriteLine($"Added {quantity} x {itemName} to inventory.");
        }

        public void DeleteItem(string itemName)
        {
            items.Remove(itemName);
        }

        public void DeleteItem(string itemName, int quantity)
        {
            if(items.ContainsKey(itemName))
            {
                items[itemName] -= quantity;
            }
            else
            {
                Console.WriteLine("Item not found!");
            }

            if(items.ContainsKey(itemName) && items[itemName] <= 0)
            {
                items.Remove(itemName);
            }
        
        }

        public void displayItems()
        {
            Console.WriteLine("\nInvetory: ");
            if(items.Count == 0)
            {
                Console.WriteLine("No items in inventory.");
            }
            else
            {
                foreach (var item in items)
                {

                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
