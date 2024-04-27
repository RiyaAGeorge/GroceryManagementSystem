using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GroceryManagementSystem
{
    public partial class FormOrder : Form
    {
        private readonly OrderFunctions _parent;

        public int Order_ID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public int CustomerID { get; set; }

        public FormOrder(OrderFunctions parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            textBoxDate.Text = DateTime.Today.ToShortDateString(); // Reset the order date to today's date in string format
            textBoxStatus.Text = textBoxTotAmount.Text = textBoxCustomer_ID.Text = string.Empty;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (textBoxStatus.Text.Trim().Length < 3)
            {
                MessageBox.Show("Order status is empty ( > 3). ");
                return;
            }

            decimal TotalAmount;
            if (!decimal.TryParse(textBoxTotAmount.Text.Trim(), out TotalAmount))
            {
                MessageBox.Show("Invalid total amount value");
                return;
            }

            int Customer_ID;
            if (!int.TryParse(textBoxCustomer_ID.Text.Trim(), out Customer_ID))
            {
                MessageBox.Show("Invalid customer ID value");
                return;
            }

            DateTime OrderDate;
            if (!DateTime.TryParse(textBoxDate.Text, out OrderDate))
            {
                MessageBox.Show("Invalid date value");
                return;
            }

            if (SaveButton.Text == "Save")
            {
                Order ord = new Order(OrderDate, textBoxStatus.Text.Trim(), TotalAmount, Customer_ID);
                DbOrder.AddOrder(ord);
                Clear();
            }

            //if (SaveButton.Text == "Update")
            //{
            //    // Create a new order object with updated values
            //    Order ord = new Order(OrderDate, textBoxStatus.Text.Trim(), TotalAmount, Customer_ID);

            //    // Update the order record in the database
            //    DbOrder.UpdateOrder(ord, Order_ID); // Update the order record in the database using the Order_ID property of the form

            //    // Refresh the DataGridView
            //    _parent.Display();
            //}

            // Refresh the DataGridView
            _parent.Display();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
