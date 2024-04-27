using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryManagementSystem
{
    public partial class EditOrder : Form
    {
        private readonly int _selectedOrderID;

        public EditOrder(int selectedOrderID)
        {
            InitializeComponent();
            _selectedOrderID = selectedOrderID;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Retrieve the values entered by the user
            string orderDateStr = textBoxDate.Text.Trim();
            string orderStatus = textBoxStatus.Text.Trim();
            decimal totalAmount;
            int customerID;

            // Parsing the order date manually
            DateTime orderDate;
            if (!DateTime.TryParse(orderDateStr, out orderDate))
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(textBoxTotAmount.Text.Trim(), out totalAmount))
            {
                MessageBox.Show("Invalid total amount value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxCustomer_ID.Text.Trim(), out customerID))
            {
                MessageBox.Show("Invalid customer ID value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Order object with the updated values
            Order updatedOrder = new Order(orderDate, orderStatus, totalAmount, customerID);

            // Call the UpdateOrder method from DbOrder.cs to update the order
            DbOrder.UpdateOrder(updatedOrder, _selectedOrderID);

            // Close the form after updating
            this.Close();
        
    
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
