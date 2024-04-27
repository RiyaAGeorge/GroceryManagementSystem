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

namespace GroceryManagementSystem
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
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

        // User registration logic
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server = 127.0.0.1; user = root; database = feelfresh; password = ";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            try
            {
                // Open the connection
                mySqlConnection.Open();

                // Retrieve user input
                string name = NameTextBox.Text.Trim();
                string email = EmailTextBox.Text.Trim();
                string address = AddressTextBox.Text.Trim();
                string phoneNumber = PhoneTextBox.Text.Trim();
                string password = PasswordTextBox.Text.Trim();

                // Insert data into users table
                string userQuery = "INSERT INTO users (Email, Password, Username) VALUES (@Email, @Password, @Username); SELECT LAST_INSERT_ID();";
                MySqlCommand userCmd = new MySqlCommand(userQuery, mySqlConnection);
                userCmd.Parameters.AddWithValue("@Email", email);
                userCmd.Parameters.AddWithValue("@Password", password);
                userCmd.Parameters.AddWithValue("@Username", name);

                int userId = Convert.ToInt32(userCmd.ExecuteScalar());

                // Insert data into customers table
                string customerQuery = "INSERT INTO customers (User_ID, Name, Email, Address, PhoneNumber) VALUES (@UserID, @Name, @Email, @Address, @PhoneNumber)";
                MySqlCommand customerCmd = new MySqlCommand(customerQuery, mySqlConnection);
                customerCmd.Parameters.AddWithValue("@UserID", userId);
                customerCmd.Parameters.AddWithValue("@Name", name);
                customerCmd.Parameters.AddWithValue("@Email", email);
                customerCmd.Parameters.AddWithValue("@Address", address);
                customerCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                customerCmd.ExecuteNonQuery();

                // Registration successful
                MessageBox.Show("Registration successful");

                // Redirect to customer login page (CustomerLogin)
                CustomerLogin customerLoginForm = new CustomerLogin();
                customerLoginForm.Show();
                this.Hide(); // Hide the current registration form

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }

        }
    }
}
