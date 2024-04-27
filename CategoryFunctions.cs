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
    public partial class CategoryFunctions : Form
    {
        public CategoryFunctions()
        {
            InitializeComponent();
        }

        public void Display()
        {
            DbCategory.DisplayAndSearchCategories("SELECT Category_ID, CategoryName FROM product_category", dataGridView1);
            dataGridView1.Refresh();
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

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the ProductFunctions form
            ProductFunctions productFunctions = new ProductFunctions();
            productFunctions.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OrderFunctions form
            OrderFunctions orderFunctions = new OrderFunctions();
            orderFunctions.Show();
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Create a new instance of the CategoryFunctions form
            CategoryFunctions categoryFunctions = new CategoryFunctions();
            categoryFunctions.Show();
        }

        // Button removed from portal
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

        private void AddCategory_Click(object sender, EventArgs e)
        {
            // Create a new instance of the FormCategory form
            FormCategory formCategory = new FormCategory(this);
            formCategory.ShowDialog();

        }

        public static void UpdateCategory(Category category, int Category_ID)
        {
            DbCategory.UpdateCategory(category, Category_ID);
        }

        private void CategoryFunctions_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DbCategory.DisplayAndSearchCategories("SELECT Category_ID, CategoryName FROM product_category WHERE CategoryName LIKE '%" + SearchBox.Text + "%'", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Extract the selected Category_ID from the DataGridView
                int selectedCategoryID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Category_ID"].Value);

                // Open the EditCategory form for updating with the selected Category_ID
                EditCategory editForm = new EditCategory(selectedCategoryID);
                editForm.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 1) // delete button is in column index 1
            {
                // Ask for confirmation before deletion
                if (MessageBox.Show("Are you sure that you want to delete this category record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Extract the Category ID from the DataGridView
                    int categoryID;
                    if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Category_ID"].Value.ToString(), out categoryID))
                    {
                        // Delete the category record
                        DbCategory.DeleteCategory(categoryID);
                        // Refresh the DataGridView
                        Display();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Category ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
