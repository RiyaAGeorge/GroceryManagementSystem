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
    class DbOrder
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

        public static void AddOrder(Order ord)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open connection explicitly here
                string sql = "INSERT INTO orders(Order_Date, Order_Status, Total_Amount, Customer_ID) VALUES (@OrderDate, @OrderStatus, @TotalAmount, @CustomerID)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@OrderDate", MySqlDbType.DateTime).Value = ord.OrderDate;
                cmd.Parameters.Add("@OrderStatus", MySqlDbType.VarChar).Value = ord.OrderStatus;
                cmd.Parameters.Add("@TotalAmount", MySqlDbType.Decimal).Value = ord.TotalAmount;
                cmd.Parameters.Add("@CustomerID", MySqlDbType.Int32).Value = ord.CustomerID;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Order hasn't been inserted\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Close connection in finally block
            }
        }

        public static void UpdateOrder(Order ord, int Order_ID)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open the connection explicitly
                string sql = "UPDATE orders SET Order_Status = @OrderStatus, Total_Amount = @TotalAmount, Order_Date = @OrderDate, Customer_ID = @CustomerID WHERE Order_ID = @OrderID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@OrderStatus", MySqlDbType.VarChar).Value = ord.OrderStatus;
                cmd.Parameters.Add("@TotalAmount", MySqlDbType.Decimal).Value = ord.TotalAmount;
                cmd.Parameters.Add("@OrderDate", MySqlDbType.DateTime).Value = ord.OrderDate;
                cmd.Parameters.Add("@CustomerID", MySqlDbType.Int32).Value = ord.CustomerID;
                cmd.Parameters.Add("@OrderID", MySqlDbType.Int32).Value = Order_ID;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Order hasn't been updated. An error occurred.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Ensure the connection is closed if it was successfully opened
            }
        }

        public static void DeleteOrder(int Order_ID)
        {
            MySqlConnection con = GetConnection();
            try
            {
                con.Open(); // Open the connection explicitly
                string sql = "DELETE FROM orders WHERE Order_ID = @Order_ID";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.Add("@Order_ID", MySqlDbType.Int32).Value = Order_ID;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Order hasn't been deleted\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // Close connection in finally block
            }
        }

        public static void DisplayAndSearchOrders(string query, DataGridView dgv)
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
