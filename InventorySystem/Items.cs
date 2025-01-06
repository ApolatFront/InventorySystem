using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class Items
    {
        public string Name {  get; set; }
        public int Quantity { get; set; }


        public Items(string name, int quantity, string description)
        {
            this.Name = name;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Name} (x{Quantity})";
        }
    }
}
