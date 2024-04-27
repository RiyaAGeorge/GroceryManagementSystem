using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace GroceryManagementSystem
{
    public class DbPayment
    {
        private static readonly MySqlConnection Connection;

        // Static constructor to initialize the connection
        static DbPayment()
        {
            string connectionString = "server=127.0.0.1;user=root;database=feelfresh;password=";
            Connection = new MySqlConnection(connectionString);
        }

        // Method to open the connection
        private static void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        // Method to close the connection
        private static void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        // Method to execute a non-query (e.g., insert, update, delete)
        private static void ExecuteNonQuery(string sql, MySqlParameter[] parameters)
        {
            try
            {
                OpenConnection();
                using (MySqlCommand command = new MySqlCommand(sql, Connection))
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

        public static void AddPayment(string paymentType, int customerId)
        {
            string sql = "INSERT INTO payment (Payment_Type, Customer_ID) VALUES (@PaymentType, @CustomerID)";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@PaymentType", paymentType),new MySqlParameter("@CustomerID", customerId)
            };

            ExecuteNonQuery(sql, parameters);
        }




    }
}
