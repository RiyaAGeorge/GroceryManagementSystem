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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
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


        //for registration
        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        //for customer login
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server = 127.0.0.1; user = root; database = feelfresh; password = ";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            //login logic

            try
            {
                mySqlConnection.Open();

                string email = EmailBox.Text.Trim();
                string password = PasswordBox.Text.Trim();

                string query = "SELECT * FROM users WHERE Email = @Email AND Password = @Password";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Customer login successful
                    MessageBox.Show("Customer login successful");

                    // Close the current login form
                    this.Hide();

                    // Open the ShopperPage form
                    ShopperPage shopperPageForm = new ShopperPage();
                    shopperPageForm.Show();
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Invalid email or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

        }
    }
}
