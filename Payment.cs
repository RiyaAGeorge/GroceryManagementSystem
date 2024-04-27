using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryManagementSystem
{
    public class Payment
    {
        // Properties
        public int Payment_ID { get; set; }
        public string Payment_Type { get; set; }
        public int Customer_ID { get; set; }

        public Payment(string payment_Type, int customer_ID)
        {
            Payment_Type = payment_Type;
            Customer_ID = customer_ID;
        }
    }
}
