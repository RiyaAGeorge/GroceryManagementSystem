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
    public partial class EditCategory : Form
    {
        private readonly int _selectedCategoryID;
        public EditCategory(int selectedCategoryID)
        {
            InitializeComponent();
            _selectedCategoryID = selectedCategoryID;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Retrieve the values entered by the user
            string categoryName = textBoxName.Text.Trim();

            // Create a new Category object with the updated values
            Category updatedCategory = new Category(categoryName);

            // Call the UpdateCategory method from CategoryFunctions.cs to update the category
            CategoryFunctions.UpdateCategory(updatedCategory, _selectedCategoryID);

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
