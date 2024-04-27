namespace GroceryManagementSystem
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Header = new Panel();
            ControlBox = new Panel();
            btnMaximize = new Button();
            btnHide = new Button();
            ApplicationHeading = new Label();
            btnClose = new Button();
            sidePanel = new Panel();
            label1 = new Label();
            VegetablesButton = new Button();
            FruitsButton = new Button();
            FoodCupboardButton = new Button();
            ProductButton = new Button();
            panel1 = new Panel();
            OrderStatusButton = new Button();
            CartButton = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Checkout = new Button();
            AddItems = new Button();
            price = new Label();
            Total = new Label();
            label2 = new Label();
            Item_ID = new DataGridViewTextBoxColumn();
            Cart_ID = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewButtonColumn();
            Header.SuspendLayout();
            ControlBox.SuspendLayout();
            sidePanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            Header.TabIndex = 3;
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
            btnMaximize.Location = new Point(36, 4);
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
            btnHide.Location = new Point(3, 4);
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
            btnClose.Location = new Point(841, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 28);
            btnClose.TabIndex = 8;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // sidePanel
            // 
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(label1);
            sidePanel.Controls.Add(VegetablesButton);
            sidePanel.Controls.Add(FruitsButton);
            sidePanel.Controls.Add(FoodCupboardButton);
            sidePanel.Controls.Add(ProductButton);
            sidePanel.Location = new Point(3, 120);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(210, 351);
            sidePanel.TabIndex = 9;
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
            // VegetablesButton
            // 
            VegetablesButton.Location = new Point(16, 245);
            VegetablesButton.Name = "VegetablesButton";
            VegetablesButton.Size = new Size(179, 42);
            VegetablesButton.TabIndex = 10;
            VegetablesButton.Text = "Vegetables";
            VegetablesButton.UseVisualStyleBackColor = true;
            VegetablesButton.Click += VegetablesButton_Click;
            // 
            // FruitsButton
            // 
            FruitsButton.Location = new Point(16, 174);
            FruitsButton.Name = "FruitsButton";
            FruitsButton.Size = new Size(179, 42);
            FruitsButton.TabIndex = 2;
            FruitsButton.Text = "Fruits";
            FruitsButton.UseVisualStyleBackColor = true;
            FruitsButton.Click += FruitsButton_Click;
            // 
            // FoodCupboardButton
            // 
            FoodCupboardButton.Location = new Point(16, 105);
            FoodCupboardButton.Name = "FoodCupboardButton";
            FoodCupboardButton.Size = new Size(179, 42);
            FoodCupboardButton.TabIndex = 1;
            FoodCupboardButton.Text = "Food Cupboard";
            FoodCupboardButton.UseVisualStyleBackColor = true;
            FoodCupboardButton.Click += FoodCupboardButton_Click;
            // 
            // ProductButton
            // 
            ProductButton.Location = new Point(16, 38);
            ProductButton.Name = "ProductButton";
            ProductButton.Size = new Size(179, 42);
            ProductButton.TabIndex = 0;
            ProductButton.Text = "All Products";
            ProductButton.UseVisualStyleBackColor = true;
            ProductButton.Click += ProductButton_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(44, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 12;
            // 
            // OrderStatusButton
            // 
            OrderStatusButton.BackgroundImage = (Image)resources.GetObject("OrderStatusButton.BackgroundImage");
            OrderStatusButton.BackgroundImageLayout = ImageLayout.Zoom;
            OrderStatusButton.Location = new Point(650, 44);
            OrderStatusButton.Name = "OrderStatusButton";
            OrderStatusButton.Size = new Size(107, 33);
            OrderStatusButton.TabIndex = 16;
            OrderStatusButton.UseVisualStyleBackColor = true;
            OrderStatusButton.Click += OrderStatusButton_Click;
            // 
            // CartButton
            // 
            CartButton.BackgroundImage = (Image)resources.GetObject("CartButton.BackgroundImage");
            CartButton.BackgroundImageLayout = ImageLayout.Zoom;
            CartButton.Location = new Point(765, 44);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(107, 33);
            CartButton.TabIndex = 17;
            CartButton.UseVisualStyleBackColor = true;
            CartButton.Click += CartButton_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(Checkout);
            panel2.Controls.Add(AddItems);
            panel2.Controls.Add(price);
            panel2.Controls.Add(Total);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(237, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(626, 349);
            panel2.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Item_ID, Cart_ID, Amount, ItemName, Column2 });
            dataGridView1.Location = new Point(28, 58);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(571, 229);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Checkout
            // 
            Checkout.Location = new Point(517, 321);
            Checkout.Name = "Checkout";
            Checkout.Size = new Size(92, 23);
            Checkout.TabIndex = 23;
            Checkout.Text = "Checkout";
            Checkout.UseVisualStyleBackColor = true;
            Checkout.Click += Checkout_Click;
            // 
            // AddItems
            // 
            AddItems.Location = new Point(371, 321);
            AddItems.Name = "AddItems";
            AddItems.Size = new Size(133, 23);
            AddItems.TabIndex = 22;
            AddItems.Text = "Add more items";
            AddItems.UseVisualStyleBackColor = true;
            AddItems.Click += AddItems_Click;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(154, 328);
            price.Name = "price";
            price.Size = new Size(12, 14);
            price.TabIndex = 21;
            price.Text = "$";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(84, 328);
            Total.Name = "Total";
            Total.Size = new Size(32, 14);
            Total.TabIndex = 20;
            Total.Text = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 21);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 19;
            label2.Text = "Cart";
            // 
            // Item_ID
            // 
            Item_ID.DataPropertyName = "Item_ID";
            Item_ID.HeaderText = "Item_ID";
            Item_ID.Name = "Item_ID";
            Item_ID.ReadOnly = true;
            // 
            // Cart_ID
            // 
            Cart_ID.DataPropertyName = "Cart_ID";
            Cart_ID.HeaderText = "Cart ID";
            Cart_ID.Name = "Cart_ID";
            Cart_ID.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // ItemName
            // 
            ItemName.DataPropertyName = "ItemName";
            ItemName.HeaderText = "ItemName";
            ItemName.Name = "ItemName";
            ItemName.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle1;
            Column2.FlatStyle = FlatStyle.Flat;
            Column2.HeaderText = "";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Text = "Delete";
            Column2.UseColumnTextForButtonValue = true;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 474);
            Controls.Add(panel2);
            Controls.Add(CartButton);
            Controls.Add(OrderStatusButton);
            Controls.Add(panel1);
            Controls.Add(sidePanel);
            Controls.Add(btnClose);
            Controls.Add(Header);
            Font = new Font("Constantia", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cart";
            Text = "Cart";
            Shown += Cart_Shown;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ControlBox.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Panel ControlBox;
        private Button btnMaximize;
        private Button btnHide;
        private Label ApplicationHeading;
        private Button btnClose;
        private Panel sidePanel;
        private Label label1;
        private Button VegetablesButton;
        private Button FruitsButton;
        private Button FoodCupboardButton;
        private Button ProductButton;
        private Panel panel1;
        private Button OrderStatusButton;
        private Button CartButton;
        private Panel panel2;
        private Button Checkout;
        private Button AddItems;
        private Label price;
        private Label Total;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Item_ID;
        private DataGridViewTextBoxColumn Cart_ID;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewButtonColumn Column2;
    }
}