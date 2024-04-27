using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GroceryManagementSystem
{
    class DbProduct
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

        public static void AddProduct(Products prod)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open connection explicitly here
                string sql = "INSERT INTO products(ProductName, Price, Quantity, Category_ID) VALUES (@ProductName, @Price, @Quantity, @Category_ID)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = prod.ProductName;
                cmd.Parameters.Add("@Price", MySqlDbType.Decimal).Value = prod.Price;
                cmd.Parameters.Add("@Quantity", MySqlDbType.Int32).Value = prod.Quantity;
                cmd.Parameters.Add("@Category_ID", MySqlDbType.Int32).Value = prod.Category_ID;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Product hasn't been inserted\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Close connection in finally block
            }
        }

        public static void UpdateProduct(Products prod, int Product_ID)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open the connection explicitly
                string sql = "UPDATE products SET ProductName = @ProductName, Price = @Price, Quantity = @Quantity, Category_ID = @Category_ID WHERE Product_ID = @Product_ID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = prod.ProductName;
                cmd.Parameters.Add("@Price", MySqlDbType.Decimal).Value = prod.Price;
                cmd.Parameters.Add("@Quantity", MySqlDbType.Int32).Value = prod.Quantity;
                cmd.Parameters.Add("@Category_ID", MySqlDbType.Int32).Value = prod.Category_ID;
                cmd.Parameters.Add("@Product_ID", MySqlDbType.Int32).Value = Product_ID;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Product hasn't been updated. An error occurred.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Ensure the connection is closed if it was successfully opened
            }
        }

        public static void DeleteProduct(int Product_ID)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open the connection explicitly
                string sql = "DELETE FROM products where Product_ID = @Product_ID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@Product_ID", MySqlDbType.Int32).Value = Product_ID;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Product hasn't been deleted\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Close connection in finally block
            }
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
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
