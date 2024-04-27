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
    public partial class FormProduct : Form
    {
        private readonly ProductFunctions _parent;

        public int Product_ID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Category_ID { get; set; }

        public FormProduct(ProductFunctions parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        //public void UpdateInfo()
        //{
            //ProductsLabel.Text = "Update Product";
           // SaveButton.Text = "Update";
           // textBoxName.Text = ProductName;
           // textBoxPrice.Text = Price.ToString(); // Convert decimal to string
            //textBoxQuantity.Text = Quantity.ToString(); // Convert int to string
            //textBoxCategory_ID.Text = Category_ID.ToString(); // Convert int to string
       // }

        public void Clear()
        {
            textBoxName.Text = textBoxPrice.Text = textBoxQuantity.Text = textBoxCategory_ID.Text = string.Empty;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Product name is empty ( > 3). ");
                return;
            }

            // if (textBoxPrice.Text.Trim().Length < 1)
            //{
            // MessageBox.Show("Price is empty ( > 1). ");
            // return;
            //}

            decimal Price;
            if (!decimal.TryParse(textBoxPrice.Text.Trim(), out Price))
            {
                MessageBox.Show("Invalid price value");
                return;
            }

            int Quantity;
            if (!int.TryParse(textBoxQuantity.Text.Trim(), out Quantity))
            {
                MessageBox.Show("Invalid quantity value");
                return;
            }

            int Category_ID;
            if (!int.TryParse(textBoxCategory_ID.Text.Trim(), out Category_ID))
            {
                MessageBox.Show("Invalid category value");
                return;
            }

            if (SaveButton.Text == "Save")
            {
                Products prod = new Products(textBoxName.Text.Trim(), Price, Quantity, Category_ID);
                DbProduct.AddProduct(prod);
                Clear();
            }

            //if (SaveButton.Text == "Update")
            //{
                // Create a new product object with updated values
                //Products prod = new Products(textBoxName.Text.Trim(), Price, Quantity, Category_ID);

                // Update the product record in the database
               // DbProduct.UpdateProduct(prod, Product_ID); // Update the product record in the database using the Product_ID property of the form

                // Refresh the DataGridView
              // _parent.Display();

            //}

            _parent.Display();
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
