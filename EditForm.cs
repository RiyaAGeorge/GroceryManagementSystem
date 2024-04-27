using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
using Mysqlx.Crud;

namespace GroceryManagementSystem
{
    public partial class EditForm : Form
    {
        private readonly int userID;
        public EditForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadUserData(userID);
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

        private void LoadUserData(int userID)
        {
            

            // Handles the case where the user data could not be retrieved
            MessageBox.Show("Failed to retrieve user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Retrieve updated user information from the form fields
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            bool isadmin = false; // Default to false
            if (textBoxIsadmin.Text.Trim() == "1") // Check if the input is "1"
            {
                isadmin = true; // Set to true if input is "1"
            }
            string email = textBoxEmail.Text;

            // Create a new User object with the updated information
            User updatedUser = new User(userID, username, password, isadmin, email);

            // Call the DbUser.UpdateUser method to update the user record in the database
            DbUser.UpdateUser(updatedUser);

            // Optionally, display a message indicating that the user information has been updated
            MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form
            this.Close();
        }
    }
}
