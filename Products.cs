using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GroceryManagementSystem
{
    public class Products
    {
        //getter and setter methods
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Category_ID { get; set; }


        //constructor
        public Products(string productName, decimal price, int quantity, int category_ID)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            Category_ID = category_ID;
        }
    }
}
