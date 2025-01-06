namespace InventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool inInventory = true;
            string item = "";
            int quantity = 0;
            InventoryHandling inventoryHandling = new InventoryHandling();

            


            while(inInventory)
            {
                Console.WriteLine("\nWelcome to the Inventory System!\n");
                Console.WriteLine("1. Add Item to your Inventory.");
                Console.WriteLine("2. Delete a whole Item from your Inventory.");
                Console.WriteLine("3. Drop Item from your inventory.");
                Console.WriteLine("4. Look into your inventory.");
                Console.WriteLine("5. Exit.");
                Console.Write("\nChoose your action: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 1)
                {
                    Console.WriteLine("Choose your name of the item: ");
                    item = Console.ReadLine();
                    Console.WriteLine("Now give the quantity of the item: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    inventoryHandling.AddItem(item, quantity);
                    
                }
                else if(number == 2)
                {
                    Console.Write("Choose your name of the item: ");
                    item = Console.ReadLine();
                    inventoryHandling.DeleteItem(item);
                    Console.WriteLine($"//{item} was deleted from your inventory.//");
                }
                else if (number == 3) 
                {
                    Console.WriteLine("Choose your name of the item: ");
                    item = Console.ReadLine();
                    Console.WriteLine("Now give the quantity of the item: ");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    inventoryHandling.DeleteItem(item, quantity);
                    Console.WriteLine($"//{quantity} x {item} was dropped from your inventory.//");
                }
                else if(number == 4)
                {
                    inventoryHandling.displayItems();
                }
                else if(number == 5)
                {
                    inInventory = false;
                }
            }
            
        }
    }
}
