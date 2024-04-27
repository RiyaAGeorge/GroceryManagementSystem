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
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
             WindowState = FormWindowState.Minimized;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string mysqlconn = "server = 127.0.0.1; user = root; database = feelfresh; password = ";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlconn);

            //logic behind login

            try
            {
                mySqlConnection.Open();

                string email = EmailBox.Text.Trim();
                string password = passwordBox.Text.Trim();

                string query = "SELECT Isadmin FROM users WHERE Email = @Email AND Password = @Password";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                object isAdminObj = cmd.ExecuteScalar();

                if (isAdminObj != null && (bool)isAdminObj)
                {
                    // Admin login successful
                    MessageBox.Show("Admin login successful");

                    // Close the current login form
                    this.Hide();

                    // Open the StaffPortal form
                    StaffPortal staffPortalForm = new StaffPortal();
                    staffPortalForm.Show();
                }
                else
                {
                    // Normal user login successful
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
