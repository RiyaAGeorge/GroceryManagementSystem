using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryManagementSystem
{
    public partial class OrderFunctions : Form
    {
        public OrderFunctions()
        {
            InitializeComponent();
        }

        public void Display()
        {
            DbOrder.DisplayAndSearchOrders("SELECT Order_ID, Order_Date, Order_Status, Total_Amount, Customer_ID FROM orders", dataGridView1);

            // Refresh the DataGridView to reflect any changes in the data source
            dataGridView1.Refresh();
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

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {

            // Create a new instance of the ProductFunctions form
            ProductFunctions productFunctions = new ProductFunctions();
            productFunctions.Show();

        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Create a new instance of the OrderFunctions form
            OrderFunctions orderFunctions = new OrderFunctions();
            orderFunctions.Show();

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the CategoryFunctions form
            CategoryFunctions categoryFunctions = new CategoryFunctions();
            categoryFunctions.Show();
        }

        //Button removed from portal

        private void StaffButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the StaffFunctions form
            //StaffFunction staffFunction = new StaffFunction();
            //staffFunction.Show();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the UserFunctions form
            UsersFunction usersFunction = new UsersFunction();
            usersFunction.Show();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            FormOrder form = new FormOrder(this);
            form.ShowDialog();
        }

        private void OrderFunctions_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Order_ID, Order_Date, Order_Status, Total_Amount, Customer_ID FROM orders WHERE Order_Status LIKE '%" + SearchBox.Text + "%'";

            // DbOrder is the class handling database operations for orders
            DbOrder.DisplayAndSearchOrders(query, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                // Extract the selected Order_ID from the DataGridView
                int selectedOrderID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Order_ID"].Value);

                // Open the EditOrder form for updating with the selected Order_ID
                EditOrder editForm = new EditOrder(selectedOrderID);
                editForm.ShowDialog();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 1) // delete button is in column index 1
            {
                // Ask for confirmation before deletion
                if (MessageBox.Show("Are you sure that you want to delete this order record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Extract the Order ID from the DataGridView
                    int orderID;
                    if (int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Order_ID"].Value.ToString(), out orderID))
                    {
                        // Delete the order record
                        DbOrder.DeleteOrder(orderID);
                        // Refresh the DataGridView
                        Display();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
