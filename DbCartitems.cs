using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace GroceryManagementSystem
{
    public class DbCartitems
    {
        private static string connectionString = "server=127.0.0.1;user=root;database=feelfresh;password=";

        // Method to get the connection
        private static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Method to execute a query and return a DataTable
        private static DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("An error occurred while executing the query.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return dataTable;
        }

        // Method to add a cart item
        public static void AddCartItem(Cartitems cartItem)
        {
            int nextCartID = GetNextCartID();
            string sql = "INSERT INTO cartitems(Cart_ID, ItemName, Amount) VALUES (@Cart_ID, @ItemName, @Amount)";

            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Cart_ID", nextCartID);
                    cmd.Parameters.AddWithValue("@ItemName", cartItem.ItemName);
                    cmd.Parameters.AddWithValue("@Amount", cartItem.Amount);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item added to cart successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Item hasn't been added to cart\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Method to update a cart item
        public static void UpdateCartItem(Cartitems cartItem, int Item_ID)
        {
            string sql = "UPDATE cartitems SET Cart_ID = @Cart_ID, ItemName = @ItemName, Amount = @Amount WHERE Item_ID = @Item_ID";

            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Cart_ID", cartItem.Cart_ID);
                    cmd.Parameters.AddWithValue("@ItemName", cartItem.ItemName);
                    cmd.Parameters.AddWithValue("@Amount", cartItem.Amount);
                    cmd.Parameters.AddWithValue("@Item_ID", Item_ID);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cart item updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Cart item hasn't been updated. An error occurred.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Method to delete a cart item
        public static void DeleteCartItem(int itemID)
        {
            string sql = "DELETE FROM cartitems WHERE Item_ID = @Item_ID";

            using (MySqlConnection connection = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Item_ID", itemID);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cart item deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Cart item hasn't been deleted\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Method to retrieve the next available Cart_ID
        public static int GetNextCartID()
        {
            int nextCartID = 0;
            string sql = "SELECT Cart_ID FROM Cartitems ORDER BY Cart_ID DESC LIMIT 1";

            DataTable result = ExecuteQuery(sql);

            if (result.Rows.Count > 0 && result.Rows[0][0] != DBNull.Value)
            {
                nextCartID = Convert.ToInt32(result.Rows[0][0]) + 1;
            }
            else
            {
                // If no suitable Cart_ID is found, return default value 1
                nextCartID = 1;
            }

            return nextCartID;
        }

        // Method to display and search cart items
        public static void DisplayAndSearchCartItems(string query, DataGridView dataGridView)
        {
            DataTable dataTable = ExecuteQuery(query);
            dataGridView.DataSource = dataTable;
            dataGridView.Refresh();
        }

        public static Cartitems GetItemDetails(int itemId)
        {
            Cartitems cartItem = null;
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open the connection explicitly

                // Prepare the SQL query to retrieve item details based on itemId
                string sql = "SELECT ItemName, Amount FROM cartitems WHERE Item_ID = @ItemId";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ItemId", itemId);

                // Execute the query and retrieve the item details
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string itemName = reader.GetString("ItemName");
                        decimal amount = reader.GetDecimal("Amount");

                        // Create a Cartitems object with the retrieved details
                        cartItem = new Cartitems(amount, itemName);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while retrieving item details.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Close connection in finally block
            }

            return cartItem;
        }
    }
}

