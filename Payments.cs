using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace GroceryManagementSystem
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
            
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

        private void CartButton_Click(object sender, EventArgs e)
        {
            Cart cartForm = new Cart();
            cartForm.ShowDialog(); // Display the form modally
        }

        private void OrderStatusButton_Click(object sender, EventArgs e)
        {
            OrderStatus orderStatusForm = new OrderStatus();
            orderStatusForm.ShowDialog(); // Display the form modally
        }

        private string GetSelectedPaymentType()
        {
            if (Cash.Checked)
            {
                return "Cash on Delivery";
            }
            else if (Online.Checked)
            {
                return "Online Payment";
            }
            else
            {
                return null; // Neither radio button is checked
            }
        }
        private void PlaceOrder_Click(object sender, EventArgs e)
        {
           // Check if a payment type is selected
           string paymentType = GetSelectedPaymentType();
            if (paymentType == null)
            {
                MessageBox.Show("Please select a payment type.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Get the customer ID from the text box
            if (!int.TryParse(CustomerIDBox.Text, out int customerId))
            {
                MessageBox.Show("Please enter a valid customer ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Call the AddPayment method to insert payment data into the database
            DbPayment.AddPayment(paymentType, customerId);

            // display a confirmation message
            MessageBox.Show("Payment placed successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

