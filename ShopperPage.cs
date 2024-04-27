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
using System.Data;

namespace GroceryManagementSystem
{
    public partial class ShopperPage : Form
    {
        
        public ShopperPage()
        {
            InitializeComponent();
            
        }

        private void ShopperPage_Load(object sender, EventArgs e)
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

        private void Cart1_Click(object sender, EventArgs e)
        {
            // Create an instance of AddToCartForm and pass the reference to cartForm
            AddToCartForm addToCartForm = new AddToCartForm();

            // Display the AddToCartForm form modally
            addToCartForm.ShowDialog();
        }

        
        // product2
        private void button1_Click(object sender, EventArgs e)
        {
            AddToCartForm addToCartForm = new AddToCartForm();
            addToCartForm.ShowDialog(); // Display the form modally
        }

        private void cart3_Click(object sender, EventArgs e)
        {
            AddToCartForm addToCartForm = new AddToCartForm();
            addToCartForm.ShowDialog(); // Display the form modally
        }

        private void cart4_Click(object sender, EventArgs e)
        {
            AddToCartForm addToCartForm = new AddToCartForm();
            addToCartForm.ShowDialog(); // Display the form modally
        }

        private void cart5_Click(object sender, EventArgs e)
        {
            AddToCartForm addToCartForm = new AddToCartForm();
            addToCartForm.ShowDialog(); // Display the form modally
        }

        private void cart6_Click(object sender, EventArgs e)
        {
            AddToCartForm addToCartForm = new AddToCartForm();
            addToCartForm.ShowDialog(); // Display the form modally
        }
    }
}
