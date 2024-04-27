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
    public partial class Cart : Form
    {
        public Cart()
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

        private void OrderStatusButton_Click(object sender, EventArgs e)
        {
            OrderStatus orderStatusForm = new OrderStatus();
            orderStatusForm.ShowDialog(); // Display the form modally
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            Cart cartForm = new Cart();
            cartForm.ShowDialog(); // Display the form modally
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ShopperPage shopperForm = new ShopperPage();
            shopperForm.ShowDialog(); // Display the form modally
        }

        private void FoodCupboardButton_Click(object sender, EventArgs e)
        {
            FoodCupboard foodCupboardForm = new FoodCupboard();
            foodCupboardForm.ShowDialog(); // Display the form modally
        }

        private void FruitsButton_Click(object sender, EventArgs e)
        {
            Fruits fruitsForm = new Fruits();
            fruitsForm.ShowDialog(); // Display the form modally
        }

        private void VegetablesButton_Click(object sender, EventArgs e)
        {
            Vegetables vegetablesForm = new Vegetables();
            vegetablesForm.ShowDialog(); // Display the form modally
        }

        private void AddItems_Click(object sender, EventArgs e)
        {
            ShopperPage shopperForm = new ShopperPage();
            shopperForm.ShowDialog(); // Display the form modally

        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            Payments paymentsForm = new Payments();
            paymentsForm.ShowDialog(); // Display the form modally
        }

        public void Display()
        {
            DbCartitems.DisplayAndSearchCartItems("SELECT Item_ID, Cart_ID, Amount, ItemName FROM cartitems", dataGridView1);

            // Refresh the DataGridView to reflect any changes in the data source
            dataGridView1.Refresh();
        }

        //public static void Display(DataGridView dataGridView1)
        //{
        // DbCartitems.DisplayAndSearchCartItems("SELECT Item_ID, Cart_ID, Amount, ItemName FROM cartitems", dataGridView);
        // dataGridView1.Refresh();
        //}
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Check if the clicked cell contains a button
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Column2" &&
                    e.RowIndex < dataGridView1.Rows.Count)
                {
                    int Item_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Item_ID"].Value);

                    // Handle the click event for the "Delete" button
                    MessageBox.Show("Delete button clicked for item ID: " + Item_ID);
                    // Call the delete method from DbCartitems
                    DbCartitems.DeleteCartItem(Item_ID);

                    // Refresh the dataGridView1 to reflect any changes
                    Display();
                }
            }
        }

        private void Cart_Shown(object sender, EventArgs e)
        {
            // Call the Display method to populate the DataGridView when the form is shown
            Display();
        }
    }
}
