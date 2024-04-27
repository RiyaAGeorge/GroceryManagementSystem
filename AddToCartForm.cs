using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace GroceryManagementSystem
{
    public partial class AddToCartForm : Form
    {

        public AddToCartForm()
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


        public void Clear()
        {
            // Clear the text boxes or any other controls used to input data
            textBoxItemName.Text = textBoxAmount.Text = string.Empty;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(textBoxItemName.Text))
            {
                MessageBox.Show("Item name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal amount;
            if (!decimal.TryParse(textBoxAmount.Text, out amount))
            {
                MessageBox.Show("Invalid amount value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new cart item object
            Cartitems cartItem = new Cartitems(amount, textBoxItemName.Text);

            // Add the cart item to the database
            DbCartitems.AddCartItem(cartItem);

            // Show success message
            MessageBox.Show("Item added to cart successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the input fields
            Clear();
        }
    }
}
