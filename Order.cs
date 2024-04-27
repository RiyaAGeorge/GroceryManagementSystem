using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryManagementSystem
{
    public class Order
    {
        //getters and setters
        public DateTime OrderDate { get; set; }  // Order_Date
        public string OrderStatus { get; set; }  // Order_Status
        public decimal TotalAmount { get; set; } // Total_Amount
        public int CustomerID { get; set; }      // Customer_ID


        //constructor
        public Order(DateTime orderDate, string orderStatus, decimal totalAmount, int customerID)
        {
            OrderDate = orderDate;
            OrderStatus = orderStatus;
            TotalAmount = totalAmount;
            CustomerID = customerID;
        }
    }
}
