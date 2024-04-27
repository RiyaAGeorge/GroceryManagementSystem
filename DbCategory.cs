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
    class DbCategory
    {
        private static MySqlConnection connection; // Private field to store the connection

        public static MySqlConnection GetConnection()
        {
            // If the connection is null or closed, create a new connection
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                string sql = "server=127.0.0.1;user=root;database=feelfresh;password=";
                connection = new MySqlConnection(sql);
            }

            return connection;
        }

        public static void AddCategory(Category category)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open connection explicitly here
                string sql = "INSERT INTO product_category(Category_ID, CategoryName) VALUES (@Category_ID, @CategoryName)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@Category_ID", MySqlDbType.Int32).Value = category.Category_ID;
                cmd.Parameters.Add("@CategoryName", MySqlDbType.VarChar).Value = category.CategoryName;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Category hasn't been inserted\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Close connection in finally block
            }
        }

        public static void UpdateCategory(Category category, int Category_ID)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open the connection explicitly
                string sql = "UPDATE product_category SET CategoryName = @CategoryName WHERE Category_ID = @Category_ID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@CategoryName", MySqlDbType.VarChar).Value = category.CategoryName;
                cmd.Parameters.Add("@Category_ID", MySqlDbType.Int32).Value = Category_ID;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Category hasn't been updated. An error occurred.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Ensure the connection is closed if it was successfully opened
            }
        }

        public static void DeleteCategory(int Category_ID)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open the connection explicitly
                string sql = "DELETE FROM product_category WHERE Category_ID = @Category_ID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@Category_ID", MySqlDbType.Int32).Value = Category_ID;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Category hasn't been deleted\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Close connection in finally block
            }
        }

        public static void DisplayAndSearchCategories(string query, DataGridView dgv)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open the connection explicitly
                string sql = query;
                MySqlCommand cmd = new MySqlCommand(sql, con);
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
                if (con.State == ConnectionState.Open)
                    con.Close(); // Close connection in finally block
            }
        }

    }
}
