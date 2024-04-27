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

namespace GroceryManagementSystem
{
    public partial class StaffPortal : Form
    {
        
        public StaffPortal()
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

        private void ProductButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of the ProductFunctions form
            ProductFunctions productFunctions = new ProductFunctions();
            productFunctions.Show();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
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

        // Button removed from portal
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

        //Not being used
        private void countUser_Click(object sender, EventArgs e)
        {
            // Retrieve and display total users
            //DisplayTotalCounts();
        }

        private void countStaff_Click(object sender, EventArgs e)
        {
            // Retrieve and display total staff
            //DisplayTotalCounts();
        }

        private void countOrder_Click(object sender, EventArgs e)
        {
            // Retrieve and display total orders
            //DisplayTotalCounts();
        }

        private void countProduct_Click(object sender, EventArgs e)
        {
            // Retrieve and display total products
            //DisplayTotalCounts();
        }
    }
}
