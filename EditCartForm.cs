using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GroceryManagementSystem
{
    public partial class EditCartForm : Form
    {
        private int Item_ID;
        public EditCartForm(int Item_ID)
        {
            InitializeComponent();
            this.Item_ID = Item_ID;
        }

        //private void SaveButton_Click(object sender, EventArgs e)
        //{

        //}

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(textBoxItemName.Text))
            {
                MessageBox.Show("Item name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal amount;
            if (!decimal.TryParse(textBoxAmount.Text, out amount))
            {
                MessageBox.Show("Invalid amount value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cartitems updatedItem = new Cartitems(amount, textBoxItemName.Text);
            DbCartitems.UpdateCartItem(updatedItem, Item_ID);

            // Show success message
            MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form
            this.Close();

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

        private void EditCartForm_Load(object sender, EventArgs e)
        {
            // Load the details of the item with the provided itemId
            LoadItemDetails();
        }

        private void LoadItemDetails()
        {
            // Use DbCartitems to retrieve the details of the item with the given Item_ID
            Cartitems cartItem = DbCartitems.GetItemDetails(Item_ID);

            // Display the retrieved details in the text boxes
            textBoxItemName.Text = cartItem.ItemName;
            textBoxAmount.Text = cartItem.Amount.ToString();
        }


    }
}
