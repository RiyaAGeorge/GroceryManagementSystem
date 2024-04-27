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
    public partial class EditProduct : Form
    {
        private readonly int _selectedProductID;
        public EditProduct(int selectedProductID)
        {
            InitializeComponent();
            _selectedProductID = selectedProductID;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Retrieve the values entered by the user
            string productName = NametextBox.Text.Trim();
            decimal price;
            int quantity, categoryID;

            if (!decimal.TryParse(PricetextBox.Text.Trim(), out price))
            {
                MessageBox.Show("Invalid price value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(QuantitytextBox.Text.Trim(), out quantity))
            {
                MessageBox.Show("Invalid quantity value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(CategoryIDtextBox.Text.Trim(), out categoryID))
            {
                MessageBox.Show("Invalid category ID value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Products object with the updated values
            Products updatedProduct = new Products(productName, price, quantity, categoryID);

            // Call the UpdateProduct method from ProductFunction.cs to update the product
            ProductFunctions.UpdateProduct(updatedProduct, _selectedProductID);

            // Close the form after updating
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void btnHide_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
