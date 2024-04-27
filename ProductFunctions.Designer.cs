namespace GroceryManagementSystem
{
    partial class ProductFunctions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFunctions));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Header = new Panel();
            ControlBox = new Panel();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            sidePanel = new Panel();
            CategoryButton = new Button();
            label1 = new Label();
            UsersButton = new Button();
            OrdersButton = new Button();
            ProductButton = new Button();
            LogoutButton = new Button();
            AdminProfile = new Panel();
            ProductPanel = new Panel();
            dataGridView1 = new DataGridView();
            Product_ID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Category_ID = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            SearchPic = new PictureBox();
            SearchBox = new TextBox();
            AddProduct = new Button();
            ProductsLabel = new Label();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            sidePanel.SuspendLayout();
            ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchPic).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BorderStyle = BorderStyle.FixedSingle;
            Header.Controls.Add(ControlBox);
            Header.Controls.Add(ApplicationHeading);
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(871, 36);
            Header.TabIndex = 7;
            // 
            // ControlBox
            // 
            ControlBox.Controls.Add(btnMaximize);
            ControlBox.Controls.Add(btnHide);
            ControlBox.Location = new Point(770, 0);
            ControlBox.Name = "ControlBox";
            ControlBox.Size = new Size(100, 35);
            ControlBox.TabIndex = 4;
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
            // btnClose
            // 
            btnClose.BackColor = Color.IndianRed;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(840, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 12;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(48, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 15;
            // 
            // sidePanel
            // 
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(CategoryButton);
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(UsersButton);
            sidePanel.Controls.Add(OrdersButton);
            sidePanel.Controls.Add(ProductButton);
            sidePanel.Location = new Point(3, 127);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(210, 351);
            sidePanel.TabIndex = 16;
            // 
            // CategoryButton
            // 
            CategoryButton.Location = new Point(16, 167);
            CategoryButton.Name = "CategoryButton";
            CategoryButton.Size = new Size(179, 42);
            CategoryButton.TabIndex = 12;
            CategoryButton.Text = "Category";
            CategoryButton.UseVisualStyleBackColor = true;
            CategoryButton.Click += CategoryButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(63, 313);
            label1.Name = "label1";
            label1.Size = new Size(90, 14);
            label1.TabIndex = 11;
            label1.Text = "@ragstudios.inc";
            // 
            // UsersButton
            // 
            UsersButton.Location = new Point(16, 240);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(179, 42);
            UsersButton.TabIndex = 10;
            UsersButton.Text = "Users";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.Location = new Point(16, 94);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(179, 42);
            OrdersButton.TabIndex = 1;
            OrdersButton.Text = "Orders";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click;
            // 
            // ProductButton
            // 
            ProductButton.Location = new Point(16, 20);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(179, 42);
            ProductButton.TabIndex = 0;
            ProductButton.Text = "Products";
            ProductButton.UseVisualStyleBackColor = true;
            ProductButton.Click += ProductButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(650, 51);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(133, 41);
            LogoutButton.TabIndex = 17;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // AdminProfile
            // 
            AdminProfile.BackgroundImage = (Image)resources.GetObject("AdminProfile.BackgroundImage");
            AdminProfile.BackgroundImageLayout = ImageLayout.Zoom;
            AdminProfile.Location = new Point(802, 44);
            AdminProfile.Name = "AdminProfile";
            AdminProfile.Size = new Size(65, 57);
            AdminProfile.TabIndex = 18;
            // 
            // ProductPanel
            // 
            ProductPanel.BackColor = SystemColors.Control;
            ProductPanel.BorderStyle = BorderStyle.FixedSingle;
            ProductPanel.Controls.Add(dataGridView1);
            ProductPanel.Controls.Add(SearchPic);
            ProductPanel.Controls.Add(SearchBox);
            ProductPanel.Controls.Add(AddProduct);
            ProductPanel.Controls.Add(ProductsLabel);
            ProductPanel.Location = new Point(219, 128);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(643, 350);
            ProductPanel.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Product_ID, ProductName, Price, Quantity, Category_ID, Column6, Column7 });
            dataGridView1.Location = new Point(6, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(632, 232);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Product_ID
            // 
            Product_ID.DataPropertyName = "Product_ID";
            Product_ID.HeaderText = "ID";
            Product_ID.Name = "Product_ID";
            Product_ID.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Product Name";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Category_ID
            // 
            Category_ID.DataPropertyName = "Category_ID";
            Category_ID.HeaderText = "Category ID";
            Category_ID.Name = "Category_ID";
            Category_ID.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.SandyBrown;
            dataGridViewCellStyle1.Font = new Font("Constantia", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            Column6.DefaultCellStyle = dataGridViewCellStyle1;
            Column6.FlatStyle = FlatStyle.Flat;
            Column6.HeaderText = "";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "Update";
            Column6.UseColumnTextForButtonValue = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.IndianRed;
            dataGridViewCellStyle2.Font = new Font("Constantia", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            Column7.DefaultCellStyle = dataGridViewCellStyle2;
            Column7.FlatStyle = FlatStyle.Flat;
            Column7.HeaderText = "";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Text = "Delete";
            Column7.UseColumnTextForButtonValue = true;
            // 
            // SearchPic
            // 
            SearchPic.BackgroundImage = (Image)resources.GetObject("SearchPic.BackgroundImage");
            SearchPic.BackgroundImageLayout = ImageLayout.Zoom;
            SearchPic.BorderStyle = BorderStyle.FixedSingle;
            SearchPic.Location = new Point(605, 15);
            SearchPic.Name = "SearchPic";
            SearchPic.Size = new Size(28, 21);
            SearchPic.TabIndex = 3;
            SearchPic.TabStop = false;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(425, 15);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(179, 22);
            SearchBox.TabIndex = 2;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(14, 308);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(100, 23);
            AddProduct.TabIndex = 1;
            AddProduct.Text = "Add Product";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductsLabel.Location = new Point(14, 16);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(142, 19);
            ProductsLabel.TabIndex = 0;
            ProductsLabel.Text = "Existing Products";
            // 
            // ProductFunctions
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 479);
            Controls.Add(ProductPanel);
            Controls.Add(AdminProfile);
            Controls.Add(LogoutButton);
            Controls.Add(sidePanel);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductFunctions";
            Text = "ProductFunctions";
            Shown += ProductFunctions_Shown;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ProductPanel.ResumeLayout(false);
            ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Panel ControlBox;
        private Button btnMaximize;
        private Button btnHide;
        private Label ApplicationHeading;
        private Button btnClose;
        private Panel panel1;
        private Panel sidePanel;
        private Button CategoryButton;
        private Label label1;
        private Button UsersButton;
        private Button OrdersButton;
        private Button ProductButton;
        private Button LogoutButton;
        private Panel AdminProfile;
        private Panel ProductPanel;
        private Button AddProduct;
        private Label ProductsLabel;
        private PictureBox SearchPic;
        private TextBox SearchBox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Product_ID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Category_ID;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
    }
}