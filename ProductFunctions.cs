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
    public partial class ProductFunctions : Form
    {
        FormProduct form;
        public ProductFunctions()
        {
            InitializeComponent();
            form = new FormProduct(this);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Display()
        {
            DbProduct.DisplayAndSearch("Select Product_ID, ProductName, Price, Quantity, Category_ID from products", dataGridView1);

            // Refresh the DataGridView to reflect any changes in the data source
            dataGridView1.Refresh();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        public static void UpdateProduct(Products prod, int Product_ID)
        {
            DbProduct.UpdateProduct(prod, Product_ID);
        }

        private void ProductFunctions_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Create a new instance of the ProductFunctions form
            ProductFunctions newForm = new ProductFunctions();
            newForm.Show();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DbProduct.DisplayAndSearch("SELECT Product_ID, ProductName, Price, Quantity, Category_ID FROM products WHERE ProductName LIKE '%" + SearchBox.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Extract the selected Product_ID from the DataGridView
                int selectedProductID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Product_ID"].Value);

                // Open the EditProduct form for updating with the selected Product_ID
                EditProduct editForm = new EditProduct(selectedProductID);
                editForm.ShowDialog();

            }

            else if (e.RowIndex >= 0 && e.ColumnIndex == 1) // delete button is in column index 1
            {
                // Ask for confirmation before deletion
                if (MessageBox.Show("Are you sure that you want to delete this product record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Extract the Product ID from the DataGridView
                    int productID;
                    if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Product_ID"].Value.ToString(), out productID))
                    {
                        // Delete the product record
                        DbProduct.DeleteProduct(productID);
                        // Refresh the DataGridView
                        Display();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OrderFunctions form
            OrderFunctions orderFunctions = new OrderFunctions();
            orderFunctions.Show();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the CategoryFunctions form
            CategoryFunctions categoryFunctions = new CategoryFunctions();
            categoryFunctions.Show();
        }

        // Button removed
        private void StaffButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the StaffFunctions form
            //StaffFunction staffFunction = new StaffFunction();
            //staffFunction.Show();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the UserFunctions form
            UsersFunction usersFunction = new UsersFunction();
            usersFunction.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    

