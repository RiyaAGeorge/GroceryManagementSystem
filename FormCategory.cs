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
    public partial class FormCategory : Form
    {
        private readonly CategoryFunctions _parent;

        public int Category_ID { get; set; }
        public string CategoryName { get; set; }
        public FormCategory(CategoryFunctions parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Clear()
        {
            textBoxName.Text = string.Empty;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Category name is empty ( > 3). ");
                return;
            }

            if (SaveButton.Text == "Save")
            {
                Category category = new Category(textBoxName.Text.Trim());
                DbCategory.AddCategory(category);
                Clear();
            }

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
