using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GroceryManagementSystem
{
    public partial class UsersFunction : Form
    {
        FormUser form;
        public UsersFunction()
        {
            InitializeComponent();
            form = new FormUser(this);
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
            this.Close();
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
            // Create a new instance of the CategoryFunctions form
            CategoryFunctions categoryFunctions = new CategoryFunctions();
            categoryFunctions.Show();
        }

        //Button removed from portal

        //private void StaffButton_Click(object sender, EventArgs e){}

        private void UsersButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Create a new instance of the UserFunctions form
            UsersFunction usersFunction = new UsersFunction();
            usersFunction.Show();


        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            FormUser form = new FormUser(this);
            form.ShowDialog();
        }

        //Added by mistake
        private void ProductPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        public void Display()
        {
            DbUser.DisplayAndSearch("SELECT User_ID, Username, Password, Isadmin, Email FROM Users", dataGridView1);
        }

        private void UsersFunction_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            DbUser.DisplayAndSearch($"SELECT User_ID, Username, Password, Isadmin, Email FROM Users WHERE Username LIKE '%{SearchBox.Text}%' OR Email LIKE '%{SearchBox.Text}%'", dataGridView1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Assuming the Delete button is in the second column
            {
                string username = dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString(); // Assuming "Username" is the column name

                if (!string.IsNullOrEmpty(username))
                {
                    if (MessageBox.Show("Are you sure that you want to delete this user record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Pass the username to the DeleteUserByUsername method
                        DbUser.DeleteUserByUsername(username);
                        Display(); // Assuming Display method refreshes the DataGridView
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
