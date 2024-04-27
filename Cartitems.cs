using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryManagementSystem
{
    public class Cartitems
    {
        // Properties
        public int Item_ID { get; set; }
        public int Cart_ID { get; set; }
        public decimal Amount { get; set; }
        public string ItemName { get; set; }

        // Constructor
        public Cartitems(decimal amount, string itemName)
        {
            Amount = amount;
            ItemName = itemName;
        }
    }
}
