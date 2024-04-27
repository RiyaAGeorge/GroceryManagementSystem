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
    public partial class RoleForm : Form
    {
        public RoleForm()
        {
            InitializeComponent();
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            // Redirect to staff login page
            var staffLogin = new StaffLogin();
            staffLogin.Show();
            this.Hide(); // hide the current form
        }

        private void ShopperButton_Click(object sender, EventArgs e)
        {
            // Redirect to customer login page
            var customerLogin = new CustomerLogin();
            customerLogin.Show();
            this.Hide(); // hide the current form
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
    }
}
