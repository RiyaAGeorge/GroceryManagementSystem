using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.VisualBasic;

namespace GroceryManagementSystem
{
    class DbUser
    {
        private static MySqlConnection connection;

        // Static constructor to initialize the connection
        static DbUser()
        {
            string connectionString = "server=127.0.0.1;user=root;database=feelfresh;password=";
            connection = new MySqlConnection(connectionString);
        }

        // Method to open the connection
        private static void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Method to close the connection
        private static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // Method to execute a non-query (e.g., insert, update, delete)
        private static void ExecuteNonQuery(string sql, MySqlParameter[] parameters)
        {
            try
            {
                OpenConnection();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameters);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Operation completed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        // Add User Method
        public static void AddUser(User user)
        {
            string sql = "INSERT INTO Users (Username, Password, Isadmin, Email) VALUES (@Username, @Password, @Isadmin, @Email)";
            MySqlParameter[] parameters = {
                new MySqlParameter("@Username", MySqlDbType.VarChar) { Value = user.Username },
                new MySqlParameter("@Password", MySqlDbType.VarChar) { Value = user.Password },
                new MySqlParameter("@Isadmin", MySqlDbType.Bit) { Value = user.Isadmin },
                new MySqlParameter("@Email", MySqlDbType.VarChar) { Value = user.Email }
            };
            ExecuteNonQuery(sql, parameters);
        }

        // Update User Method
        public static void UpdateUser(User user)
        {
            string sql = "UPDATE Users SET Username = @Username, Password = @Password, Isadmin = @Isadmin, Email = @Email WHERE User_ID = @User_ID";
            MySqlParameter[] parameters = {
                new MySqlParameter("@Username", MySqlDbType.VarChar) { Value = user.Username },
                new MySqlParameter("@Password", MySqlDbType.VarChar) { Value = user.Password },
                new MySqlParameter("@Isadmin", MySqlDbType.Bit) { Value = user.Isadmin },
                new MySqlParameter("@Email", MySqlDbType.VarChar) { Value = user.Email },
                new MySqlParameter("@User_ID", MySqlDbType.Int32) { Value = user.User_ID }
            };
            ExecuteNonQuery(sql, parameters);
        }

        public static void DeleteUserByUsername(string username)
        {
            try
            {
                // Perform deletion
                string sql = "DELETE FROM Users WHERE Username = @Username";
                MySqlParameter parameter = new MySqlParameter("@Username", MySqlDbType.VarChar) { Value = username };
                ExecuteNonQuery(sql, new[] { parameter });
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Failed to delete user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // display and search users
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            try
            {
                OpenConnection();
                string sql = query;
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                dgv.DataSource = tbl; // Bind the DataTable to the provided DataGridView
                dgv.Refresh(); // Refresh the DataGridView to reflect any changes in the data source
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while executing the query.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
        }

        




    }
}
