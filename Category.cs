using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GroceryManagementSystem
{
    public class Category
    {
        // Getter and setter for Category_ID
        public int Category_ID { get; set; }

        // Getter and setter for CategoryName
        public string CategoryName { get; set; }


        // Constructor
        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
