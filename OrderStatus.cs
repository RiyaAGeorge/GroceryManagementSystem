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
    public partial class OrderStatus : Form
    {
        public OrderStatus()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
    }
}
