namespace GroceryManagementSystem
{
    partial class EditProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            Header = new Panel();
            ControlBox = new Panel();
            btnClose = new Button();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            SaveButton = new Button();
            textBoxQuantity = new TextBox();
            textBoxCategory_ID = new TextBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            CategoryIDLabel = new Label();
            QuantityLabel = new Label();
            PriceLabel = new Label();
            ProdNameLabel = new Label();
            panel3 = new Panel();
            EditProductsLabel = new Label();
            panel4 = new Panel();
            buttonSave = new Button();
            QuantitytextBox = new TextBox();
            CategoryIDtextBox = new TextBox();
            PricetextBox = new TextBox();
            NametextBox = new TextBox();
            CategoryID = new Label();
            Quantity = new Label();
            Price = new Label();
            ProductName = new Label();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BorderStyle = BorderStyle.FixedSingle;
            Header.Controls.Add(ControlBox);
            Header.Controls.Add(ApplicationHeading);
            Header.Location = new Point(2, 1);
            Header.Name = "Header";
            Header.Size = new Size(871, 36);
            Header.TabIndex = 9;
            // 
            // ControlBox
            // 
            ControlBox.Controls.Add(btnClose);
            ControlBox.Controls.Add(btnMaximize);
            ControlBox.Controls.Add(btnHide);
            ControlBox.Location = new Point(770, 0);
            ControlBox.Name = "ControlBox";
            ControlBox.Size = new Size(100, 35);
            ControlBox.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(69, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 13;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = Color.YellowGreen;
            btnMaximize.BackgroundImage = (Image)resources.GetObject("btnMaximize.BackgroundImage");
            btnMaximize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Location = new Point(37, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(28, 28);
            btnMaximize.TabIndex = 5;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.NavajoWhite;
            btnHide.BackgroundImage = (Image)resources.GetObject("btnHide.BackgroundImage");
            btnHide.BackgroundImageLayout = ImageLayout.Zoom;
            btnHide.FlatAppearance.BorderSize = 0;
            btnHide.FlatStyle = FlatStyle.Flat;
            btnHide.Location = new Point(5, 4);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(28, 28);
            btnHide.TabIndex = 4;
            btnHide.UseVisualStyleBackColor = false;
            btnHide.Click += btnHide_Click;
            // 
            // ApplicationHeading
            // 
            ApplicationHeading.AutoSize = true;
            ApplicationHeading.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ApplicationHeading.Location = new Point(11, 8);
            ApplicationHeading.Name = "ApplicationHeading";
            ApplicationHeading.Size = new Size(186, 19);
            ApplicationHeading.TabIndex = 3;
            ApplicationHeading.Text = "<- Feel Fresh Application";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Beige;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(EditProductsLabel);
            panel2.Location = new Point(-3, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(879, 95);
            panel2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(textBoxQuantity);
            panel1.Controls.Add(textBoxCategory_ID);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(CategoryIDLabel);
            panel1.Controls.Add(QuantityLabel);
            panel1.Controls.Add(PriceLabel);
            panel1.Controls.Add(ProdNameLabel);
            panel1.Location = new Point(56, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 259);
            panel1.TabIndex = 13;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.Beige;
            SaveButton.Location = new Point(302, 233);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(207, 39);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(230, 126);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(327, 22);
            textBoxQuantity.TabIndex = 7;
            // 
            // textBoxCategory_ID
            // 
            textBoxCategory_ID.Location = new Point(230, 170);
            textBoxCategory_ID.Name = "textBoxCategory_ID";
            textBoxCategory_ID.Size = new Size(327, 22);
            textBoxCategory_ID.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(230, 79);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(327, 22);
            textBoxPrice.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(230, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(327, 22);
            textBoxName.TabIndex = 4;
            // 
            // CategoryIDLabel
            // 
            CategoryIDLabel.AutoSize = true;
            CategoryIDLabel.Location = new Point(44, 178);
            CategoryIDLabel.Name = "CategoryIDLabel";
            CategoryIDLabel.Size = new Size(73, 14);
            CategoryIDLabel.TabIndex = 3;
            CategoryIDLabel.Text = "Category ID:";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(44, 134);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(57, 14);
            QuantityLabel.TabIndex = 2;
            QuantityLabel.Text = "Quantity:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(44, 87);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(37, 14);
            PriceLabel.TabIndex = 1;
            PriceLabel.Text = "Price:";
            // 
            // ProdNameLabel
            // 
            ProdNameLabel.AutoSize = true;
            ProdNameLabel.Location = new Point(44, 37);
            ProdNameLabel.Name = "ProdNameLabel";
            ProdNameLabel.Size = new Size(86, 14);
            ProdNameLabel.TabIndex = 0;
            ProdNameLabel.Text = "Product Name:";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.Location = new Point(19, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 66);
            panel3.TabIndex = 16;
            // 
            // EditProductsLabel
            // 
            EditProductsLabel.AutoSize = true;
            EditProductsLabel.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditProductsLabel.Location = new Point(392, 42);
            EditProductsLabel.Name = "EditProductsLabel";
            EditProductsLabel.Size = new Size(112, 19);
            EditProductsLabel.TabIndex = 9;
            EditProductsLabel.Text = "Edit Products";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(buttonSave);
            panel4.Controls.Add(QuantitytextBox);
            panel4.Controls.Add(CategoryIDtextBox);
            panel4.Controls.Add(PricetextBox);
            panel4.Controls.Add(NametextBox);
            panel4.Controls.Add(CategoryID);
            panel4.Controls.Add(Quantity);
            panel4.Controls.Add(Price);
            panel4.Controls.Add(ProductName);
            panel4.Location = new Point(49, 148);
            panel4.Name = "panel4";
            panel4.Size = new Size(778, 291);
            panel4.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Beige;
            buttonSave.Location = new Point(302, 233);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(207, 39);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(230, 126);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(327, 22);
            QuantitytextBox.TabIndex = 7;
            // 
            // CategoryIDtextBox
            // 
            CategoryIDtextBox.Location = new Point(230, 170);
            CategoryIDtextBox.Name = "CategoryIDtextBox";
            CategoryIDtextBox.Size = new Size(327, 22);
            CategoryIDtextBox.TabIndex = 6;
            // 
            // PricetextBox
            // 
            PricetextBox.Location = new Point(230, 79);
            PricetextBox.Name = "PricetextBox";
            PricetextBox.Size = new Size(327, 22);
            PricetextBox.TabIndex = 5;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(230, 32);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(327, 22);
            NametextBox.TabIndex = 4;
            // 
            // CategoryID
            // 
            CategoryID.AutoSize = true;
            CategoryID.Location = new Point(44, 178);
            CategoryID.Name = "CategoryID";
            CategoryID.Size = new Size(73, 14);
            CategoryID.TabIndex = 3;
            CategoryID.Text = "Category ID:";
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(44, 134);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(57, 14);
            Quantity.TabIndex = 2;
            Quantity.Text = "Quantity:";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(44, 87);
            Price.Name = "Price";
            Price.Size = new Size(37, 14);
            Price.TabIndex = 1;
            Price.Text = "Price:";
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Location = new Point(44, 37);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(86, 14);
            ProductName.TabIndex = 0;
            ProductName.Text = "Product Name:";
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 463);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProduct";
            Text = "EditProduct";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Panel ControlBox;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnHide;
        private Label ApplicationHeading;
        private Panel panel2;
        private Panel panel3;
        private Label EditProductsLabel;
        private Panel panel1;
        private Button SaveButton;
        private TextBox textBoxQuantity;
        private TextBox textBoxCategory_ID;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private Label CategoryIDLabel;
        private Label QuantityLabel;
        private Label PriceLabel;
        private Label ProdNameLabel;
        private Panel panel4;
        private Button buttonSave;
        private TextBox QuantitytextBox;
        private TextBox CategoryIDtextBox;
        private TextBox PricetextBox;
        private TextBox NametextBox;
        private Label CategoryID;
        private Label Quantity;
        private Label Price;
        private Label ProductName;
    }
}